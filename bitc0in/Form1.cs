using Newtonsoft.Json;
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

namespace bitc0in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getRateBtn_Click(object sender, EventArgs e)
        {
          if(currencyMenu.SelectedItem.ToString() == "EUR", "USD")
          {
                resultLbl.Visible = true;
                vault.Visible = true;

                BitcoinRates resultRates = Rates();
                int userCoins = Int32.Parse(amountOfBtc.Text);
                float currentRate = resultRates.bpi.EUR.rate_float;
                float btcResult = userCoins * currentRate;
                vault.Text = $"{btcResult}{resultRates.bpi.EUR.code}";
          }
        }

        public static BitcoinRates Rates()
            {
                string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

                HttpWebRequest request = WebRequest.Create(url);
                request.Method = "GET";

                BitcoinRates bitcoin;

                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                using (var responseReader = new StreamReader(webStream))
                {
                    var response = responseReader.ReadToEnd();
                    bitcoin = JsonConvert.DeserializeObject<BitCoinRate>(response);
                }

                return bitcoin;

            }
        }

    internal class BitCoinRate
    {
    }
}
}
