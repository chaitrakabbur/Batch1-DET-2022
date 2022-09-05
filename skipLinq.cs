using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class skipLinq
    {
        public static void Main23()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(5);

            Console.WriteLine("Skips the first 5 words:");
            foreach (string word in result)
                Console.WriteLine(word);
        }
    }
}
