namespace Multi_Tool_Project.Tools
{
    partial class TDL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBoxLow = new CheckedListBox();
            checkedListBoxHigh = new CheckedListBox();
            checkedListBoxMedium = new CheckedListBox();
            txtTaskName = new TextBox();
            datePicker = new DateTimePicker();
            cmbPriority = new ComboBox();
            btnAddTask = new Button();
            btnDeleteTask = new Button();
            btnModifyTask = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnInstruction = new Button();
            label5 = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // checkedListBoxLow
            // 
            checkedListBoxLow.FormattingEnabled = true;
            checkedListBoxLow.Location = new Point(506, 326);
            checkedListBoxLow.Name = "checkedListBoxLow";
            checkedListBoxLow.Size = new Size(466, 112);
            checkedListBoxLow.TabIndex = 1;
            // 
            // checkedListBoxHigh
            // 
            checkedListBoxHigh.FormattingEnabled = true;
            checkedListBoxHigh.Location = new Point(506, 57);
            checkedListBoxHigh.Name = "checkedListBoxHigh";
            checkedListBoxHigh.Size = new Size(466, 112);
            checkedListBoxHigh.TabIndex = 2;
            // 
            // checkedListBoxMedium
            // 
            checkedListBoxMedium.FormattingEnabled = true;
            checkedListBoxMedium.Location = new Point(506, 192);
            checkedListBoxMedium.Name = "checkedListBoxMedium";
            checkedListBoxMedium.Size = new Size(466, 112);
            checkedListBoxMedium.TabIndex = 3;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(245, 56);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(206, 23);
            txtTaskName.TabIndex = 4;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(12, 57);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 5;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(12, 104);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 6;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(245, 89);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(100, 50);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(351, 145);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(100, 50);
            btnDeleteTask.TabIndex = 8;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnModifyTask
            // 
            btnModifyTask.Location = new Point(351, 89);
            btnModifyTask.Name = "btnModifyTask";
            btnModifyTask.Size = new Size(100, 50);
            btnModifyTask.TabIndex = 9;
            btnModifyTask.Text = "Modify";
            btnModifyTask.UseVisualStyleBackColor = true;
            btnModifyTask.Click += btnModifyTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 308);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 10;
            label1.Text = "Low";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 174);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Medium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 39);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "High";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 9);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "TASKS";
            // 
            // btnInstruction
            // 
            btnInstruction.Location = new Point(245, 145);
            btnInstruction.Name = "btnInstruction";
            btnInstruction.Size = new Size(100, 50);
            btnInstruction.TabIndex = 14;
            btnInstruction.Text = "Instructions";
            btnInstruction.UseVisualStyleBackColor = true;
            btnInstruction.Click += btnInstruction_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 9);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 15;
            label5.Text = "To-Do-List";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 41);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(77, 397);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 41);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 39);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 18;
            label6.Text = "Set Due Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 86);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Set Priority:";
            // 
            // TDL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(label5);
            Controls.Add(btnInstruction);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModifyTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnAddTask);
            Controls.Add(cmbPriority);
            Controls.Add(datePicker);
            Controls.Add(txtTaskName);
            Controls.Add(checkedListBoxMedium);
            Controls.Add(checkedListBoxHigh);
            Controls.Add(checkedListBoxLow);
            Name = "TDL";
            Text = "TDL";
            Load += TDL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxLow;
        private CheckedListBox checkedListBoxHigh;
        private CheckedListBox checkedListBoxMedium;
        private TextBox txtTaskName;
        private DateTimePicker datePicker;
        private ComboBox cmbPriority;
        private Button btnAddTask;
        private Button btnDeleteTask;
        private Button btnModifyTask;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnInstruction;
        private Label label5;
        private Button btnExit;
        private Button btnReturn;
        private Label label6;
        private Label label7;
    }
}