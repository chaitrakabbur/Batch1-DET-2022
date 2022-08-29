using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CompanyManager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }

        public string Print()
        {
            return $"Name={Name}, Surname={Surname}, PhonNo={PhoneNo}";

        }
    }
}
