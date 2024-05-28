using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools.Sec
{
    public partial class passwordGenerator : Form
    {
        public passwordGenerator()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDownLength.Value;
            bool includeSymbols = checkBoxIncludeSymbols.Checked;

            string password = GeneratePassword(length, includeSymbols);
            textBoxPassword.Text = password;
        }

        private string GeneratePassword(int length, bool includeSymbols)
        {
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string symbols = "!@#$%^&*()_+[]{}|;:,.<>?";

            string charSet = lowerCase + upperCase + digits;
            if (includeSymbols)
            {
                charSet += symbols;
            }

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charSet.Length);
                password.Append(charSet[index]);
            }

            return password.ToString();
        }

        private void passwordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Security securityForm = new Security();
            securityForm.Show();
            this.Hide();
        }
    }
}