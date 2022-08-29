using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Program3
    {
        public static void Main2()
        {
            Circle c = new Circle { Radius = 4 };
            Sphere s = new Sphere { Radius = 4 };

            Console.WriteLine(c.Area());
            Console.WriteLine(s.Area());
        }
    }
}


