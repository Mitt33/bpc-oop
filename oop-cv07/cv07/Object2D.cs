using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public abstract class Object2D : I2D, IComparable
    {
        protected double Area { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Object2D obj2D = obj as Object2D;
            if (obj2D != null)
                return this.Area.CompareTo(obj2D.Area);
            else
                throw new ArgumentException("Object is not object2D");
        }
    

    public abstract double ComputeArea();
    
    }
}
