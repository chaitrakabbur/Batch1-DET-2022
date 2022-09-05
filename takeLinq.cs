using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class takeLinq
    {
        public static void Main25()
        {
            int[] numbers = {5,2,4,3,7,8,9,10,2,32,12,56,8,9,45,34,};

            var result = numbers.Take(7);

            Console.WriteLine("Takes the first 7 numbers only:");
                  foreach (int number in result)
                   Console.WriteLine(number);
        }
    }
}
