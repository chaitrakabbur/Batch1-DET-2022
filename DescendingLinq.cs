using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class DescendingLinq
    {
        public static void Main()
        {

            {
                string[] names = { "harshitha", "ammu", "rashmi","nancy" };

                var result = names.OrderByDescending(n => n);

                Console.WriteLine("Descending ordered list of names:");
                foreach (string name in result)
                    Console.WriteLine(name);
            }
        }
    }
}
