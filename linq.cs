using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class linq
    {
        private static void Main17()
        {
            //the three parts os a LINQ Query:deffered execution
            //1. data source
           List<int> number = new List<int>();
            number.Add(110);
            number.Add(100);
           number.Add(105);
            number.Add(102);

            //2.Query creation .sql type
            //ex for deffered execution
            //var numQuery = (from num in number   //select num from numbers
            //                    select num);


            // var numQuery = (from num in number  //select num from numbers
            //                where num>102       
            //                select num).ToList();

            //number.Add(200);

            //lamda exp
            // var numQuery = number.Select(x => x); 

            var numQuery = number.Where(x => x > 102);

            //**************************************************************************************************
            //*practice*
            //List<int> number = new List<int>();
            //number.Add(200);
            //number.Add(150);
            //number.Add(1000);
            //number.Add(500);
            //number.Add(1500);
            //number.Add(2000);
            //number.Add(300);
            //number.Add(2500);

            //2.Query creation .sql type
            //var numQuery = (from num in number   //select num from numbers
            // select num);

            //var numQuery = (from num in number  //select num from numbers
            //                where num<3500 
            //                   select num).ToList();

            // number.Add(3500);

            //lamda exp
            //var numQuery = number.Select(x => x); 
            //var numQuery = number.Where(x => x > 2000);

            //*******************************************************************************************************

            //3.Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
                //num.Dump();//this is for LINQpad not for VS
            }
            Console.ReadLine(); 


        }
    }
}
