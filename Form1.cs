using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToCurrencyBox.SelectedItem = "USD";
            FromCurrencyBox.SelectedItem = "EURO";
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;

            using(var client = new WebClient())
            {
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{fromCurrency}");
            }

            var data = JObject.Parse(json);
            var rate = (double)data["rates"][toCurrency];

            return rate;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            string fromCurrency = FromCurrencyBox.SelectedItem.ToString();
            string toCurrency = ToCurrencyBox.SelectedItem.ToString();

            double amount;
            if(!double.TryParse(AmountToConvertToBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to convert.", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving the exchange rate!", "API Error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;
            ConvertedAmountDisplay.Text = ConvertedAmountDisplay.Text.Replace("___", convertedAmount.ToString("F2") + " " + toCurrency);
            RateDisplay.Text = $"Conversion Rate: 1 {fromCurrency} = {1 * exchangeRate} {toCurrency}";
        }
    }
}
