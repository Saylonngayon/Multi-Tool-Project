using Multi_Tool_Project.Tools.Sec; // Import the correct namespace for passwordGenerator
using System;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools
{
    public partial class Security : Form
    {
        public Security()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordGenerator pgForm = new passwordGenerator(); // Instantiate the passwordGenerator form
            pgForm.Show(); // Show the passwordGenerator form
            this.Hide(); // Hide the current form (Security)
        }

        private void buttonCrpytography_Click(object sender, EventArgs e)
        {
            Cryptography cForm = new Cryptography();
            cForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainHub mainHubForm = new mainHub();
            mainHubForm.Show();
            this.Hide();
        }

        private void Security_Load(object sender, EventArgs e)
        {

        }
    }
}