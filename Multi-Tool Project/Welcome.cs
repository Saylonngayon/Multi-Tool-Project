using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace Multi_Tool_Project
{
    public partial class Welcome : Form
    {

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            mainHub mainHubForm = new mainHub();
            MessageBox.Show("Navigating to the Main Hub.", "Navigating", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(500);
            this.Hide();
            Thread.Sleep(500);
            mainHubForm.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            Credits creditsForm = new Credits();
            MessageBox.Show("Navigating to the Credits Menu.", "Navigating", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(500);
            this.Hide();
            Thread.Sleep(500);
            creditsForm.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the System, Goodbye!");
            Thread.Sleep(50);
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
