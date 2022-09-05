using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class employeeLinq
    {
        public employeeLinq()
        {

        }

        public employeeLinq(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        private static List<employeeLinq> GetListofemployeeLinq()
        {
            List<employeeLinq> emps = new List<employeeLinq>();
            emps.Add(new employeeLinq(1, "John", "Training"));
            emps.Add(new employeeLinq(2, "Mark", "Finance"));
            emps.Add(new employeeLinq(3, "Peter", "Technical")); 
            emps.Add(new employeeLinq(4, "Bob", "Technical"));
            emps.Add(new employeeLinq(5, "Robert", "Finance"));
            emps.Add(new employeeLinq(6, "Jason", "Training"));

            return emps;
           
        }

            private static void SampleemployeeLinq()
            {
                List<employeeLinq> emps = GetListofemployeeLinq();
                var emp_query = from employee in emps
                                select employee;

                foreach (var item in emp_query)
                {
                    Console.WriteLine("Name is " + item.Name + "and dept is " + item.Dept);

                }

            }


            public static void Main16()
            {
                SampleemployeeLinq();
            }
        }
    }