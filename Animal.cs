using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Sound { get; set; }
        public string Name { get; set; }
        public abstract string sound();
        
    }
}
