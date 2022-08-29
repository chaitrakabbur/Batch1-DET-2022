using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Person
    {
        string firstname;
        string lastname;
        string email;
        DateOnly dob;
        public Person (string firstname, string lastname, string email, DateOnly dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.dob = dob;
        }
        public Person (string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public Person(string firstname, string lastname, DateOnly dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
        }
        private static int calculateAge(DateOnly dob)
        {
            int age = 0;
            age=DateTime.Now.Year - dob.Year;
            return age;
        }
        public int birthyear()
        {
            return dob.Year;
        }
        public string getinfo()
        {
            return $"Firstname={firstname}, Lastname={lastname}";
        }
        public string IsAdult()
        {
            int age = calculateAge(dob);
            if (age>=18)
            {
                return "The person is an adult";
            }
            else
            {
                return "The person is not an adult";
            }
        }
        public string GetSunSign()
        {
            string str = string.Empty;
            int month = dob.Month;
            int day = dob.Day;
            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
            {
                return "Aires";
            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
            {
                return "Taurus";
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
            {
                return "Gemini";
            }
            if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
            {
                return "Cancer";
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
            {
                return "leo";
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))
            {
                return "Virgo";
            }
            else
            {
                return "SUN SIGN UNKOWN";
            }
        }
        public string BDayStatus()
        {
            var dateNow = DateOnly.FromDateTime(DateTime.Now);
            if (dob == dateNow)
            {
                return "IT IS THE PERSON'S BIRTHDAY";
            }
            else
            {
                return "IT IS NOT THE PERSON'S BIRTHDAY";
            }
        }
        public string DefaultUsername()
        {
            return $"{firstname}{lastname}{dob.Year}";
        }
        public string ChineseZodiac()
        {
            int year = dob.Year;
            if (year % 12 == 0) { return "Monkey"; }
            else if (year % 12 == 1) { return "Rooster"; }
            else if (year % 12 == 2) { return "Dog"; }
            else if (year % 12 == 3) { return "Pig"; }
            else if (year % 12 == 4) { return "Rat"; }
            else if (year % 12 == 5) { return "Ox"; }
            else if (year % 12 == 6) { return "Tiger"; }
            else if (year % 12 == 7) { return "Rabbit"; }
            else if (year % 12 == 8) { return "Dragon"; }
            else if (year % 12 == 9) { return "Snake"; }
            else if (year % 12 == 10) { return "Horse"; }
            else { return "Sheep"; }
        }

    }
}
