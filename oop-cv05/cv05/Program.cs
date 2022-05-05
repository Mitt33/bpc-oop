using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PassengerCar c1 = new PassengerCar(250, Car.FuelType.diesel, 5, 5, 120);
                Lorry l1 = new Lorry(500, Car.FuelType.petrol, 1000, 40, 280);
                Console.WriteLine(c1);
                Console.WriteLine(l1);
                c1.TurnRadio(true);
                Console.WriteLine(c1);
                c1.SetRadioPreset(2, 104.78);
                c1.SetRadioPreset(3, 99.54);
                c1.TuneByIndex(2);
                Console.WriteLine(c1);
                c1.TuneManualy(122.47);
                Console.WriteLine(c1);
                c1.TurnRadio(false);
                Console.WriteLine(c1);
                try 
                { 
                    c1.Refuel(Car.FuelType.diesel, 2500);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                c1.Refuel(Car.FuelType.diesel, 25);
                Console.WriteLine(c1);

                try
                {
                    l1.Refuel(Car.FuelType.diesel, 100);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(l1);

                l1.TransportedCargo = 450;
                Console.WriteLine(l1);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
