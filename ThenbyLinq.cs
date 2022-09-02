using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ThenbyLinq
    {
        public static void Main()
        {
            string[] capitals = { "sonata", "software", "Mindtree", "IBM", "Bangalore","USA",
                          "Seoul" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }
    }
    }

