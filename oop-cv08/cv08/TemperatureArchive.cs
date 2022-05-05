using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv08
{
    class TemperatureArchive
    {
        private SortedDictionary<int, YearTemperature> _archive = new SortedDictionary<int, YearTemperature>();

        public void AddToArchive(YearTemperature yearTemperature)
        {
            _archive.Add(yearTemperature.Year, yearTemperature);
        }

        private const string Directory = "C:\\Users\\Student\\source\\repos\\cv08";
        public void Load(string file)
        {
            try
            {
                string path = Path.Combine(Directory, file);
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    List<double> temperature = new List<double>();
                    line.Replace(" ", "");
                    string[] splitter = line.Split(new char[] { ':', ';' });
                    for (int i = 0; i < splitter.Length; i++)
                    {
                        temperature.Add(Convert.ToDouble(splitter[i]));
                    }
                    _archive.Add(Convert.ToInt32(splitter[0]), new YearTemperature(Convert.ToInt32(splitter[0]), temperature));
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e)
            {
                throw new Exception("fail", e);
            }
        }
        public void Save(string file)
        {
            string path = Path.Combine(Directory, file);
            StreamWriter sw = new StreamWriter(path);
            SortedDictionary<int, YearTemperature>.ValueCollection valueColl = _archive.Values;

            foreach (YearTemperature yt in valueColl)
            {
                sw.Write(String.Format("{0}: " + String.Join("; ", yt.MonthTemperature.Select(r => string.Format("{0:N1}", r))) + "\n",yt.Year));
            }
            sw.Close();
        }
        public YearTemperature FindYeartemperature(int year)
        {
            if (_archive.TryGetValue(year, out YearTemperature value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }
        public void Calibration(double calValue)
        {
            SortedDictionary<int, YearTemperature>.ValueCollection valueColl = _archive.Values;
            foreach (YearTemperature yt in valueColl)
            {
                yt.Calibration(calValue);
            }

        }
        public string PrintTemperature()
        {
            StringBuilder sb = new StringBuilder();
           // SortedDictionary<int, YearTemperature>.ValueCollection valueColl = _archive.Values;
            foreach (YearTemperature yt in _archive.Values)
            {
                sb = sb.AppendLine(String.Format("{0}", yt));
            }
            return sb.ToString();


        }
        public string AvgYearTemperature()
        {
            StringBuilder sb = new StringBuilder();
            SortedDictionary<int, YearTemperature>.ValueCollection valueColl = _archive.Values;
            foreach (var yt in valueColl)
            {
                sb = sb.AppendLine(String.Format("{0}: {1:N1}", yt.Year, yt.AvgTemperature));
            }
            return sb.ToString();
        }
        public string AvgMonthTemperature()
        {
            StringBuilder sb = new StringBuilder();
            SortedDictionary<int, YearTemperature>.ValueCollection valueColl = _archive.Values;
            List<double> avgMonthTemeperature = new List<double>();
            double monthAvg;
            int tmp = 0;
            for (int i = 0; i < _archive.FirstOrDefault().Value.MonthTemperature.Count(); i++)
            {
                monthAvg = 0;
                tmp = 0;
                foreach (var item in valueColl)
                {
                    monthAvg += item.MonthTemperature[i];
                    tmp++;
                }
                avgMonthTemeperature.Add(monthAvg / tmp);
            }
            sb = sb.AppendLine(String.Format(String.Join(" ", avgMonthTemeperature.Select(r => string.Format("{0:N1}", r)))));
            return sb.ToString();

        }

    }
}
