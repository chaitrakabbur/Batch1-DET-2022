using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public abstract class Shape
    {
        public int Radius { get; set; }

        public abstract double Area();
    }

    public class Circle : Shape
    {
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Sphere : Shape
    {
        public override double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }
    }
}
