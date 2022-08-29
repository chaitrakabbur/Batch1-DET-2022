using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class StudentProgram
    {
        public static Student Student { get; private set; }

        public static void main()
        {
            ScienceStudent Student = new ScienceStudent { regno = 12, Name = "Neha" };
            ScienceStudent sciencesubject = new ScienceStudent { physics = 54, chemistry = 75, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }
    }
}
