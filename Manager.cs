using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    // derived class from emp
    internal class Manager:Emp
    {
        public string Project { get; set; }
        public int Teamsize { get; set; }
        public Manager(int id, string name, DateTime doj, string project, int teamsize)
        {
            this.Project=project;
            Teamsize=teamsize;  
        }
    }
}
