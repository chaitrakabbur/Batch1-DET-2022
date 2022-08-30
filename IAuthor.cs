using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface IEmail
    {
        string SendEmail();

    }
    public interface INotify
    {
        string SendSMS();
    }

    class Author : IEmail, INotify
    {
        public string Name { get ; set ; }
        public string Email { get ; set ; }
        public char Gender { get ; set ; }

        public string SendEmail()
        {
            return $"Mail sent to {Name}, {Email},{Gender}";
        }
        public string SendSMS()
        {
            return $"{Name} subscribed SMS notifications";
        }

    }
    class SITLAuthor :Author, IEmail
    {

        public string SendEmail()
        {
            return $"Mail sent to Name={Name}, Email={Email},Gender={Gender}";
        }

    }
    class TestAuthor
    {
        public static void Main()
        {
            Author a = new Author { Name = "Chaitra", Email = "ck@s.com", Gender = 'F' };
            SITLAuthor sa = new SITLAuthor { Name = "ABC", Email = "abc@s.com", Gender = 'F' };
            Console.WriteLine(a.SendEmail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEmail());
        }
    }
}
