using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class PassengerCar : Car
    {
        private int transportedPersons;
        public int TransportedPersons
        {
            get { 
                return this.transportedPersons;
                }
            set { 
                this.transportedPersons = CheckNumberOfPersons(value); 
                }
        }
        public int MaxPersons { get; set; }

        public PassengerCar(double tankSize, FuelType fuel, int transportedPersons, int maxPersons, double tankCondition = 0) : base(tankSize, tankCondition, fuel)
        {
                MaxPersons = maxPersons;
                TransportedPersons = transportedPersons;
            
        }
        private int CheckNumberOfPersons(int persons)
        {
            if (persons <= MaxPersons)
            {
                return persons;
            }
            else
            {
                throw new ArgumentOutOfRangeException("to manz people :(");
            }
        }


        public override string ToString()
        {
            return String.Format("Car/ {0}. There are {1} people out of {2}", base.ToString(),TransportedPersons, MaxPersons);
        }
    }
}
