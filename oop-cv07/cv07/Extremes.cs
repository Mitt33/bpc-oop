using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Extremes
    {
        public static T Smallest<T>(T[] values) where T : IComparable
        {
            T minimum = values.ElementAt(0);
            foreach (var value in values)
            {
                    int compared = value.CompareTo(minimum);
                    if (compared < 0)
                    {
                    minimum = value;
                    }
                }
            
            return minimum;
        }

        public static T Biggest<T>(T[] values) where T : IComparable
        {
            T maximum = values.ElementAt(0);
            foreach (var value in values)
            {
                int compared = value.CompareTo(maximum);
                if (compared > 0)
                {
                    maximum = value;
                }
            }

            return maximum;
        }

    }
    
}
