using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    abstract public class Car
    {
        private CarRadio Radio;
        public enum FuelType
        {
            petrol, diesel
        }

        public double TankSize{get; set;}
        public double TankCondition { get; set; }
        public FuelType Fuel { get; set; }

        public Car(double tankSize, double tankCondition, FuelType fuel)
        {
            TankCondition = tankCondition;
            TankSize = tankSize;
            Fuel = fuel;
            Radio = new CarRadio();
        }

        public void Refuel(FuelType fuel, double amount)
        {
            if (Fuel != fuel)
            {
                throw new ArgumentException("wrong fuel :(");
            }
            if (TankCondition + amount > TankSize)
            {
                throw new ArgumentException("no way you have money to so much fuel (tank is full)");
            }
            else
            {
                TankCondition = TankCondition + amount;
            }
        }

        private double GetRadioFreq()
        {
            return Radio.Freq;
        }
        public bool RadioIsTurnOn()
        {
            return Radio.IsOn;
        }
        public void TurnRadio (bool onOff)
        {
            Radio.IsOn = onOff;
        }
        public void SetRadioPreset(int index, double freq)
        {
            Radio.SetPreset(index, freq);
        }
        public void TuneByIndex(int index)
        {
            Radio.TuneFromPreset(index);
        }
        public void TuneManualy(double freq)
        {
            Radio.Freq = freq;
        }


        public override string ToString()
        {
            return String.Format("in {0} tank is: {1} out of {2}. {3}", Fuel, TankCondition, TankSize, Radio.ToString());
        }
    }
}
