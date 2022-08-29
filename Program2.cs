using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Program2
    {
        static void main()
        {
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (age > 120)
                {
                    throw new Exception("age is invalid");
                }
                else
                {
                    Console.WriteLine($"age is {age}");
                }
            }
            catch (InvalidAgeException i)
            {
                Console.WriteLine(i.message);
            }
            catch (Exception e)
            {
            }

        }
    }
}
