using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            CalcData calcData = new CalcData
            {
                Operation = cbOperation.Text,
                Operand1 = Convert.ToDecimal(txtOperand1.Text),
                Operand2 = Convert.ToDecimal(txtOperand2.Text)
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44306/");

            
            HttpResponseMessage response = client.PostAsJsonAsync("api/values", calcData).Result;


            if (response.IsSuccessStatusCode)
            {
                decimal result = response.Content.ReadAsAsync<decimal>().Result;
                lblResult.Content = result.ToString();

            }
            else
            {
                throw new Exception("response not succesfull");
            }

        }
    }
}
