using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ReverseLinq
    {
        public static void Main21()
        {
            char[] characters = { 'h', 'a', 'r', 's', 'h', 'i','t','h','a' };

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (char character in result)
                Console.WriteLine(character);
        }

    }
}
