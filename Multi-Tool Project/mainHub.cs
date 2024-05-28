using Multi_Tool_Project.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project
{
    public partial class mainHub : Form     
    {

        public mainHub()
        {
            InitializeComponent();
        }

        private void mainHub_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the System, Goodbye!");
            Thread.Sleep(50);
            Application.Exit();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            calculator.Calculator calculatorForm = new calculator.Calculator();
            calculatorForm.Show();
            this.Hide();
        }

        private void btnTDL_Click(object sender, EventArgs e)
        {
            TDL TDLForm = new TDL();
            TDLForm.Show();
            this.Hide();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            FinanceTool financeForm = new FinanceTool();
            financeForm.Show();
            this.Hide();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            Security securityForm = new Security();
            securityForm.Show();
            this.Hide();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Converter converterForm = new Converter();
            converterForm.Show();
            this.Hide();
        }
    }
}
