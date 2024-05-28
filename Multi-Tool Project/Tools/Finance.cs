using Multi_Tool_Project.Tools.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools
{
    public partial class FinanceTool : Form
    {
        public FinanceTool()
        {
            InitializeComponent();
        }

        private void btnsimpleInterest_Click(object sender, EventArgs e)
        {
            SimpleInterest simpleInterestForm = new SimpleInterest();
            simpleInterestForm.Show();
            this.Hide();
        }

      

        private void btninvestmentReturns_Click(object sender, EventArgs e)
        {
            investmentReturns investmentReturnsForm = new investmentReturns();
            investmentReturnsForm.Show();
            this.Hide();
        }

        private void btncurrencyExchange_Click(object sender, EventArgs e)
        {
            currencyExchange currencyExchangeForm = new currencyExchange();
            currencyExchangeForm.Show();
            this.Hide();
        }

        private void FinanceTool_Load(object sender, EventArgs e)
        {

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
    }
}
