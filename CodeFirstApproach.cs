using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    public class CodeFirstApproach
    {

        static void Main()
        {
            //AddNewBook();
            //UpdateNewBook();
            //DeleteBook();
            //GetAllBooks();
            //AddcustomerAndOrder();
            //NewAddcustomerAndOrder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            DisconnectedArchitecture();
            Console.ReadLine();
        }

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 3;
        //    book.BookName = "The Run Machine";
        //    book.author = "virat";
        //    book.price = 1000;

        //    Book book2 = new Book();
        //    book.BookID = 6;
        //    book.BookName = "The Alchemist";
        //    book.author = "Paulo Coelho";
        //    book.price = 2000;

        //    //Book book3 = new Book();
        //    //book.BookID = 5;
        //    //book.BookName = "A Million Thoughts";
        //    //book.author = "Astha Anand";
        //    //book.price = 5000;

        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" new book added successfylly");

        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void UpdateNewBook()
        //{
        //    var ctx = new BookContext();
        //    var Book = ctx.Book.Where(e => e.BookID == 3).SingleOrDefault();

        //    Book.author = "VK";
        //    ctx.Update(Book);
        //    ctx.SaveChanges();
        //    Console.WriteLine("The book is updated");
        //}

        //private static void DeleteBook()
        //{
        //    var ctx = new BookContext();

        //    try
        //    {
        //        Book book = new Book();
        //        book.BookID = 3;

        //        ctx.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("The book is deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //}

        //private static void GetAllBooks()
        //{
        //    var ctx = new BookContext();
        //    var books = ctx.Book;

        //    foreach (var book in books)
        //    {
        //        Console.WriteLine(book.BookName);
        //    }
        //}

        private static void AddcustomerAndOrder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Chaitra";
            customer.Age = 21;

            Order ord = new Order();
            ord.Order_ID = 777;
            ord.Amount = 5000;
            ord.OrderDate=DateTime.Now;

            //List<Order> myorders = new List<Order>();
            //myorders.Add(ord);
            //customer.Orders = myorders;

            ord.cust = customer;
            try
            {
                //ctx.Customer.Add(customer); //Orders
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("Customer and order is created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }

            
        }

        private static void NewAddcustomerAndOrder()
        {
            var ctx = new BookContext();
            var customer = ctx.Customers.Where(x => x.ID == 1).SingleOrDefault();
            Order ord = new Order();
            ord.Order_ID = 5855;
            ord.Amount = 10000;
            ord.OrderDate = DateTime.Now;
            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("New Order is added");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }

        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DisconnectedArchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            // ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }
}
