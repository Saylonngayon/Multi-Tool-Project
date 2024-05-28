using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multi_Tool_Project.Tools.Finance
{
    public partial class currencyExchange : Form
    {
        private const string API_URL = "https://openexchangerates.org/api/latest.json?app_id=7a66aff6c7524a33961c3f830b10182b";
        private JObject ratesJson;

        public currencyExchange()
        {
            InitializeComponent();
        }

        private void currencyExchange_Load(object sender, EventArgs e)
        {
            try
            {
                string json;
                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(API_URL);
                }

                ratesJson = JObject.Parse(json);

                foreach (var currency in ratesJson["rates"].OfType<JProperty>())
                {
                    cmbBaseCurrency.Items.Add(currency.Name);
                    cmbTargetCurrency.Items.Add(currency.Name);
                }

                cmbBaseCurrency.SelectedIndex = 0;
                cmbTargetCurrency.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching exchange rates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string baseCurrency = cmbBaseCurrency.SelectedItem.ToString();
                string targetCurrency = cmbTargetCurrency.SelectedItem.ToString();
                double amount = Convert.ToDouble(txtAmount.Text);

                double baseRate = (double)ratesJson["rates"][baseCurrency];
                double targetRate = (double)ratesJson["rates"][targetCurrency];

                double convertedAmount = (amount / baseRate) * targetRate;

                lblResult.Text = "Total: " + convertedAmount.ToString("0.00") + targetCurrency;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting currency: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FinanceTool financeForm = new FinanceTool();
            financeForm.Show();
            this.Hide();
        }
    }
}