using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> teplotyList = new List<double>() { 2, 3, 5, 4.4, 8 };

            YearTemperature yt = new YearTemperature(2022, teplotyList);
            TemperatureArchive ta = new TemperatureArchive();
            ta.Load("teploty.txt");
            Console.WriteLine("hodnoty: ");
            Console.WriteLine(ta.PrintTemperature());
            Console.WriteLine("hodnoty roku 2010: ");
            Console.WriteLine(ta.FindYeartemperature(2010));
            Console.WriteLine("prumerne rocni hodnoty: ");
            Console.WriteLine(ta.AvgYearTemperature());
            Console.WriteLine("prumerne mesicni teploty: ");
            Console.WriteLine(ta.AvgMonthTemperature());
            ta.Save("teplotyLoaded.txt");

            ta.Calibration(-0.1);
            Console.WriteLine("hodnoty po kalibraci: ");
            Console.WriteLine(ta.PrintTemperature());



            Console.ReadLine();

        }
    }
}
