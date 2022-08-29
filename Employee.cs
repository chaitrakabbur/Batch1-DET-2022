using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Employee
    {
        int rollno;
        string name;
        string address;
        int pincode;
        long phonenumber;
        int GrossSal;
        int pf;

        public Employee(int rollno, string name, string address, int pincode, long phonenumber, int grossSal, int pf)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phonenumber = phonenumber;
            GrossSal = grossSal;
            //this.pf = pf;
        }
        public int GetEmpNetSal()
        {
            int Netsal;
            pf = 12 * GrossSal / 100;
            Netsal = GrossSal - pf;
            return Netsal;
        }
        public char GetEmpGrade()
        {
            if (GetEmpNetSal() > 10000)
            {
                return 'A'
;
            }
            else if (GetEmpNetSal() > 5000)
            {
                return 'B';
            }
            else
                return 'C';
        }
    }
}
