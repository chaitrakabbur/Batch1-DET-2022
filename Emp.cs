using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Batch1_DET_2022
{
    internal class Emp
    {
        //data declared inside class are known as "fields"
        int id;
        string name;
        string dept;
        double sal;
        DateTime doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Emp(int id, string name, DateTime doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public Emp()
        {
            id = -1; name = "no name";
        }
        public Emp(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsOfExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public virtual string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsOfExp()} Years";
        }

        public static void main()
        {
            Emp m = new Manager(4671, "karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                               // console.writeline(m.print());

            Emp m1 = new Manager(2345, "jeeva", new DateTime(2010, 1, 14), "pems", 450);
            // console.writeline(m1.print());  //base class ref can point to derived object

            Emp e1 = new Emp(1, "jiyana", new DateTime(2020, 1, 5));
            //console.writeline(e1.print());

            List<Emp> list = new List<Emp>();
            list.Add(m);
            list.Add(m1);
            list.Add(e1);
            foreach (Emp x in list)
            Console.WriteLine(x.Print());

        }

       
    }
}
