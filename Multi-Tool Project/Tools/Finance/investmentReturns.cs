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
    public partial class investmentReturns : Form
    {
        public investmentReturns()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                double rate = double.Parse(textBoxRate.Text) / 100; // Convert percentage to decimal
                double principal = double.Parse(textBoxPrincipal.Text);
                int days = string.IsNullOrEmpty(textBoxDays.Text) ? 0 : int.Parse(textBoxDays.Text);
                int months = string.IsNullOrEmpty(textBoxMonths.Text) ? 0 : int.Parse(textBoxMonths.Text);
                int years = string.IsNullOrEmpty(textBoxYears.Text) ? 0 : int.Parse(textBoxYears.Text);

                // Determine investment return calculation type
                double totalAmount = 0;
                if (radioButtonFixedROI.Checked)
                {
                    totalAmount = CalculateFixedROI(principal, rate, days, months, years);
                }
                else if (radioButtonCompoundInterest.Checked)
                {
                    if (radioButtonDaily.Checked)
                    {
                        totalAmount = CalculateDailyCompoundInterest(principal, rate, days, months, years);
                    }
                    else if (radioButtonMonthly.Checked)
                    {
                        totalAmount = CalculateMonthlyCompoundInterest(principal, rate, days, months, years);
                    }
                    else if (radioButtonYearly.Checked)
                    {
                        totalAmount = CalculateYearlyCompoundInterest(principal, rate, days, months, years);
                    }
                }

                // Display the result
                labelOutput.Text = $"Total Value: {totalAmount:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private double CalculateFixedROI(double principal, double rate, int days, int months, int years)
        {
            // Convert everything to years
            double totalYears = (days / 365.0) + (months / 12.0) + years;
            return principal * (1 + rate * totalYears);
        }

        private double CalculateDailyCompoundInterest(double principal, double rate, int days, int months, int years)
        {
            // Convert months and years to days
            double totalDays = days + (months * 30) + (years * 365);
            double dailyRate = rate / 365;
            return principal * Math.Pow(1 + dailyRate, totalDays);
        }

        private double CalculateMonthlyCompoundInterest(double principal, double rate, int days, int months, int years)
        {
            // Convert days and years to months
            double totalMonths = (days / 30.0) + months + (years * 12);
            double monthlyRate = rate / 12;
            return principal * Math.Pow(1 + monthlyRate, totalMonths);
        }

        private double CalculateYearlyCompoundInterest(double principal, double rate, int days, int months, int years)
        {
            // Convert days and months to years
            double totalYears = (days / 365.0) + (months / 12.0) + years;
            return principal * Math.Pow(1 + rate, totalYears);
        }
    }
}