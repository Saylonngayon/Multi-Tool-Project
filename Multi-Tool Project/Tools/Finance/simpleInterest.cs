using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools.Finance
{
    public partial class SimpleInterest : Form
    {
        public SimpleInterest()
        {
            InitializeComponent();
        }

        private void SimpleInterest_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FinanceTool FinanceForm = new FinanceTool();
            FinanceForm.Show();
            this.Hide();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                double rate = double.Parse(textBoxRate.Text);
                double deposit = double.Parse(textBoxDeposit.Text);
                int days = string.IsNullOrEmpty(textBoxDays.Text) ? 0 : int.Parse(textBoxDays.Text);
                int months = string.IsNullOrEmpty(textBoxMonths.Text) ? 0 : int.Parse(textBoxMonths.Text);
                int years = string.IsNullOrEmpty(textBoxYears.Text) ? 0 : int.Parse(textBoxYears.Text);

                // Determine interest calculation type
                double totalInterest = 0;
                if (radioButtonDaily.Checked)
                {
                    totalInterest = CalculateDailyInterest(deposit, rate, days, months, years);
                }
                else if (radioButtonMonthly.Checked)
                {
                    totalInterest = CalculateMonthlyInterest(deposit, rate, days, months, years);
                }
                else if (radioButtonYearly.Checked)
                {
                    totalInterest = CalculateYearlyInterest(deposit, rate, days, months, years);
                }

                // Display the result
                labelOutput.Text = $"Total Value: {deposit + totalInterest:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private double CalculateDailyInterest(double principal, double rate, int days, int months, int years)
        {
            // Convert months and years to days
            double totalDays = days + (months * 30) + (years * 365);
            return principal * rate / 100 * totalDays;
        }

        private double CalculateMonthlyInterest(double principal, double rate, int days, int months, int years)
        {
            // Convert days and years to months
            double totalMonths = (days / 30.0) + months + (years * 12);
            return principal * rate / 100 * totalMonths;
        }

        private double CalculateYearlyInterest(double principal, double rate, int days, int months, int years)
        {
            // Convert days and months to years
            double totalYears = (days / 365.0) + (months / 12.0) + years;
            return principal * rate / 100 * totalYears;
        }
    }
}