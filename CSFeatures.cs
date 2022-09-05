using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main13()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hi {name}"); };
            //action.Invoke("Chaitra");
            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hi {s1}, " + $"is having{s2}"); };

            action.Invoke("Chaitra");
            action1.Invoke("Chaitra", " a good day");

            Action<int, string, string> printEmp = (int id, string name, string email) =>
            {
                Console.WriteLine($"id={id}, name={name}, email={email}");
            };
            printEmp(7575, "Chaitra", "CK@s.com");
        }
    }
}
