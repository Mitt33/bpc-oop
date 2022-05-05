using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class CarRadio
    {   
        private Dictionary<int,double> preset;
        public double Freq { get; set; }
        public bool IsOn { get; set; }
        public CarRadio (double freq = 0)
        {
            Freq = freq;
            IsOn = false;
            this.preset = new Dictionary<int, double>();
        }
        public void SetPreset (int index, double freq)
        {
            if (IsOn == true)
            {


                if (!this.preset.ContainsKey(index))
                {
                    this.preset.Add(index, freq);
                }
                else
                {
                    this.preset.Remove(index);
                    this.preset.Add(index, freq);
                }
            }
            else
            {
                throw new Exception("turn on radio before creating presets");
            }
        }
        public void TuneFromPreset(int index)
        {
            if (IsOn == true) {
                if (this.preset.TryGetValue(index, out double value))
                {
                    this.Freq = value;
                }
                else
                {
                    throw new ArgumentException("not in preset");
                }
            }
            else
            {
                throw new Exception("turn on radio before tuning");
            }
        }


        public override string ToString()
        {
            if (IsOn)
            {
                return String.Format("radio freq is: {0}", this.Freq);
            }
            else
            {
                return "radio is turn of";
            }s
        }
    }
}
