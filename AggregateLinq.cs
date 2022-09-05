using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class AggregateLinq
    {
        public static void Main11()
        {
            sum();
        }

        static void Aggregate() {

            var numbers = new int[] { 5, 6, 3, 2, 7, 2 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }


        static void Average() {
            int[] numbers = { 23, 45, 67, 89 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }



        static void count()
        {

            string[] names = { "ammu", "harshitha", "nancy", "chaitra" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }




        static void max()
        {

            int[] numbers = { 2, 8, 5, 6, 1, 23, 45, 67, 8, 9, 23 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }

          

        static void mini()
        {
            int[] numbers = { 7, 8, 9, 1, 2, 3, 4, 0, -1 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }



        static void sum()
        { 
            int[] numbers = { 2,3,4,5,6,7 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);


        }


    }
}
