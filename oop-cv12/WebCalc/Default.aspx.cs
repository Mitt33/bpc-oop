using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCalc.Models;

namespace WebCalc
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
        }

        protected async void btnCalc_Click(object sender, EventArgs e)
        {
            CalcData calcData = new CalcData
            {
                Operation = ddOperation.SelectedValue,
                Operand1 = Convert.ToDecimal(txtOperand1.Text),
                Operand2 = Convert.ToDecimal(txtOperand2.Text)
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44306/");
            HttpResponseMessage response =
            client.PostAsJsonAsync("api/values", calcData).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ltrResult.Text = result.ToString();
            }
            

        }
    }
}