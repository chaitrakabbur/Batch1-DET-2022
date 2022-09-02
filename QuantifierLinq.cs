using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class QuantifierLinq
    {
        public static void Main()
        {
            Contains();
        }
        static void All()
        {
            string[] names = { "Ammu", "Amual", "Anusha", "Anju" };

            var result = names.All(n => n.StartsWith("A"));

            Console.WriteLine("Does all of the names start with the letter 'A':");
            Console.WriteLine(result);
        }
        static void Any()
        {
            string[] names = { "Phone", "Song", "Army", "BTS" };

            var result = names.Any(n => n.StartsWith("u"));

            Console.WriteLine("Does any of the names start with the letter 'u':");
            Console.WriteLine(result);
        }
        static void Contains()
        {
            int[] numbers = { 1, 3, 8, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }
    }


    }