using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multi_Tool_Project.Tools
{
    public partial class TDL : Form
    {
        class TaskItem
        {
            public string TaskName { get; set; }
            public DateTime DueDate { get; set; }
            public string Priority { get; set; }

            public override string ToString()
            {
                return $"{TaskName} (Due: {DueDate.ToShortDateString()})";
            }
        }
        Dictionary<string, List<TaskItem>> tasksByPriority = new Dictionary<string, List<TaskItem>>();
        private const string FileName = "tasks.json";


        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainHub mainHubForm = new mainHub();
            mainHubForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public TDL()
        {
            InitializeComponent();
            tasksByPriority.Add("Low", new List<TaskItem>());
            tasksByPriority.Add("Medium", new List<TaskItem>());
            tasksByPriority.Add("High", new List<TaskItem>());

            cmbPriority.Items.Add("Low");
            cmbPriority.Items.Add("Medium");
            cmbPriority.Items.Add("High");
            cmbPriority.SelectedIndex = 0;

            LoadTasks();

            this.FormClosing += Form1_FormClosing;
        }
        private void TDL_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (datePicker.Value.Date < DateTime.Today)
            {
                MessageBox.Show("The due date cannot be in the past.");
                return;
            }

            TaskItem newTask = new TaskItem
            {
                TaskName = txtTaskName.Text,
                DueDate = datePicker.Value,
                Priority = cmbPriority.SelectedItem.ToString()
            };

            tasksByPriority[newTask.Priority].Add(newTask);
            UpdateCheckListBox(newTask.Priority);

            txtTaskName.Clear();
            datePicker.Value = DateTime.Today;
            cmbPriority.SelectedIndex = 0;

            SaveTasks();
        }

        private void btnModifyTask_Click(object sender, EventArgs e)
        {
            string selectedTask = GetSelectedTask(checkedListBoxLow) ??
                                    GetSelectedTask(checkedListBoxMedium) ??
                                    GetSelectedTask(checkedListBoxHigh);
            string priority = selectedTask != null ? GetPriority(selectedTask) : null;

            if (selectedTask == null || priority == null)
            {
                MessageBox.Show("Please select a task to modify.");
                return;
            }

            string[] parts = selectedTask.Split(new string[] { " (Due: " }, StringSplitOptions.RemoveEmptyEntries);
            string taskName = parts[0];
            DateTime dueDate = DateTime.Parse(parts[1].TrimEnd(')'));

            string newTaskName = Interaction.InputBox("Enter new task name:", "Modify Task", taskName);
            string newDueDateStr = Interaction.InputBox("Enter new due date (MM/dd/yyyy):", "Modify Due Date", dueDate.ToShortDateString());
            DateTime newDueDate;
            if (!DateTime.TryParse(newDueDateStr, out newDueDate))
            {
                MessageBox.Show("Invalid date format. Please enter the date in MM/dd/yyyy format.");
                return;
            }
            if (newDueDate.Date < DateTime.Today)
            {
                MessageBox.Show("The due date cannot be in the past.");
                return;
            }
            string newPriority = cmbPriority.SelectedItem.ToString();

            foreach (TaskItem task in tasksByPriority[priority])
            {
                if (task.ToString() == selectedTask)
                {
                    task.TaskName = newTaskName;
                    task.DueDate = newDueDate;
                    task.Priority = newPriority;
                    break;
                }
            }

            UpdateCheckListBox(priority);
            if (priority != newPriority)
            {
                UpdateCheckListBox(newPriority);
            }

            SaveTasks();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            List<string> selectedTasks = GetSelectedTasks(checkedListBoxLow);
            selectedTasks.AddRange(GetSelectedTasks(checkedListBoxMedium));
            selectedTasks.AddRange(GetSelectedTasks(checkedListBoxHigh));

            if (selectedTasks.Count == 0)
            {
                MessageBox.Show("Please select tasks to delete.");
                return;
            }

            foreach (string task in selectedTasks)
            {
                string priority = GetPriority(task);
                if (priority != null && tasksByPriority.ContainsKey(priority))
                {
                    tasksByPriority[priority].RemoveAll(t => t.ToString() == task);
                }
            }

            UpdateCheckListBox("Low");
            UpdateCheckListBox("Medium");
            UpdateCheckListBox("High");

            SaveTasks();
        }

        private string GetSelectedTask(CheckedListBox listBox)
        {
            if (listBox.SelectedItem != null)
            {
                return listBox.SelectedItem.ToString();
            }
            return null;
        }

        private List<string> GetSelectedTasks(CheckedListBox listBox)
        {
            List<string> selectedTasks = new List<string>();
            foreach (var item in listBox.CheckedItems)
            {
                selectedTasks.Add(item.ToString());
            }
            return selectedTasks;
        }

        private string GetPriority(string taskName)
        {
            foreach (var kvp in tasksByPriority)
            {
                if (kvp.Value.Exists(task => task.ToString() == taskName))
                {
                    return kvp.Key;
                }
            }
            return null;
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxLow.Tag = "Low";
            checkedListBoxMedium.Tag = "Medium";
            checkedListBoxHigh.Tag = "High";
        }

        private void UpdateCheckListBox(string priority)
        {
            List<TaskItem> tasks = tasksByPriority[priority];

            tasks = tasks.OrderBy(t => t.DueDate).ToList();

            switch (priority)
            {
                case "Low":
                    checkedListBoxLow.Items.Clear();
                    foreach (TaskItem task in tasks)
                    {
                        checkedListBoxLow.Items.Add(task.ToString());
                    }
                    break;
                case "Medium":
                    checkedListBoxMedium.Items.Clear();
                    foreach (TaskItem task in tasks)
                    {
                        checkedListBoxMedium.Items.Add(task.ToString());
                    }
                    break;
                case "High":
                    checkedListBoxHigh.Items.Clear();
                    foreach (TaskItem task in tasks)
                    {
                        checkedListBoxHigh.Items.Add(task.ToString());
                    }
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks();
        }

        private void SaveTasks()
        {
            var tasksList = tasksByPriority.SelectMany(kvp => kvp.Value).ToList();
            string jsonString = JsonSerializer.Serialize(tasksList);
            File.WriteAllText(FileName, jsonString);
        }

        private void LoadTasks()
        {
            if (File.Exists(FileName))
            {
                string jsonString = File.ReadAllText(FileName);
                var tasksList = JsonSerializer.Deserialize<List<TaskItem>>(jsonString);

                tasksByPriority["Low"].Clear();
                tasksByPriority["Medium"].Clear();
                tasksByPriority["High"].Clear();

                foreach (var task in tasksList)
                {
                    tasksByPriority[task.Priority].Add(task);
                }

                UpdateCheckListBox("Low");
                UpdateCheckListBox("Medium");
                UpdateCheckListBox("High");
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            string instructions = "To-Do List Application Instructions:\n\n" +
                          "1. Add Task: Enter task name, select due date, and priority, then click 'Add Task'.\n" +
                          "2. Modify Task: Select a task from the list, update task details, and click 'Modify Task'.\n" +
                          "3. Delete Task: Select task(s) from the list and click 'Delete Task'.\n" +
                          "4. Save Tasks: Tasks are automatically saved when added, modified, or deleted.\n" +
                          "5. Close Application: Tasks will be automatically saved when closing the application.\n" +
                          "6. For any further assistance, feel free to contact support.";

            MessageBox.Show(instructions, "To-Do List Application Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}