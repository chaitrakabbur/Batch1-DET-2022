using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class orderbynumber
    {


        private static void Main()
        {
            {
                int[] numbers = { 2,4,7,1,8,4,3,0,6,9 };

                var result = from n in numbers
                             orderby n
                             select n;

                Console.WriteLine("Ordered list of numbers:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }
        }
    }
}