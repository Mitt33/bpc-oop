using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv08
{
    class YearTemperature
    {
        private List<Double> monthTemperature;
        public List<Double> MonthTemperature
        {
            get
            {
                return monthTemperature;
            }
            set
            {
                monthTemperature = value;
            }
        }
        public int Year { get; set; }
        public YearTemperature(int year, List<double> monthTemperature)
        {
            if (monthTemperature != null)
            {
                MonthTemperature = monthTemperature;
            }
            else
            {
                MonthTemperature = new List<double>();
            }
            Year = year;
            AvgTemperature = CountAvgTemperature();
            MinTemperature = CountMinTemperature();
            MaxTemperature = CountMaxTemperature();
        }

        public readonly double MaxTemperature;
        public readonly double MinTemperature;
        public readonly double AvgTemperature;
        private double CountAvgTemperature()
        {

            return monthTemperature.Average();
        }

        private double CountMinTemperature()
        {
            /*List<double> sortMin = monthTemperature.ToList();
            sortMin.Sort();
            return sortMin.ElementAt(0);*/
            return monthTemperature.Min();
        }

        private double CountMaxTemperature()
        {
           /* List<double> sortMax = monthTemperature.ToList();
            sortMax.Sort();
            return sortMax.Last();*/
            return monthTemperature.Max();
        }

        public override string ToString()
        {
          
            return String.Format("{0}: " + String.Join(" ", monthTemperature.Select(r => string.Format("{0:N1}", r))), Year);
        }
        public void Calibration(double calValue)
        {
            for (int i = 0; i < monthTemperature.Count(); i++)
            {
                monthTemperature[i] += calValue;
            }
        }

    }
    
}
