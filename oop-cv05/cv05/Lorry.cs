using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class Lorry : Car
    {
        private double transportedCargo;
        public double TransportedCargo
        {
            get
            {
                return this.transportedCargo;
            }
            set
            {
                this.transportedCargo = CheckCargo(value);
            }
        }
        public int MaxCargo{ get; set; }

        public Lorry(double tankSize, FuelType fuel, int maxCargo, double tankCondition = 0, int transportedCargo = 0) : base(tankSize, tankCondition, fuel)
        {
            MaxCargo = maxCargo;
            TransportedCargo = transportedCargo;

        }
        private double CheckCargo(double cargo)
        {
            if (cargo <= MaxCargo)
            {
                return cargo;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return String.Format("Lorry/ {0}. There is {1} cargo out of {2}", base.ToString(), TransportedCargo, MaxCargo);
        }
    }
}
