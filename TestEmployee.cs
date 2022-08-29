using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmployee
    {
        public static void Main()
        {
            Employee e = new Employee(222, "Chaitra", "Banglore", 560055, 9685369875, 300000, 1800);
            Console.WriteLine($"Your Grade is {e.GetEmpGrade()}");
        }
    }
}
