using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class DatabaseEF
    {
        static void Main()
        {
            //GetAllEmpDetails();
            //GetEmpDetailByID();
            //AddNewEmployee();
            //DeleteNewEmployee();
            //UpdateEmpDetails();
            //GetEmpDetailsWithoutSP();
            //GetEmpDetailsWithSP();
            //UpdateEmpDetailsSP();
            updatename();




            Console.ReadLine();

        }

        private static void GetAllEmpDetails()
        {
            var ctx = new LearningContext();
            var emps = ctx.Emps;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Ename);
            }
        }


        private static void GetEmpDetailByID()
        {
            var ctx = new LearningContext();
            var emp = ctx.Emps.Where(e => e.Empno == 7521).SingleOrDefault();
            Console.WriteLine(emp.Ename + "  " + emp.Sal + "  " + emp.Job);

        }


        private static void AddNewEmployee()
        {
            var ctx = new LearningContext();

            try
            {
                Batch1_DET_2022.Models.Emp employee = new Models.Emp();

                employee.Empno = 2979;
                employee.Ename = "Chaitra";
                employee.Sal = 1000;
                employee.Deptno = 30;
                employee.Job = "trainer";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("new employee added");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        static void DeleteNewEmployee()
        {
            var ctx = new LearningContext();

            try
            {
                Batch1_DET_2022.Models.Emp employee = new Models.Emp();
                employee.Empno = 7654;
                ctx.Remove(employee);

                ctx.SaveChanges();
                Console.WriteLine(" employee deleted");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }

        static void UpdateEmpDetails()
        {
            var ctx = new LearningContext();
            var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

            emp.Ename = "Neha";
            ctx.Update(emp);
            ctx.SaveChanges();
            Console.WriteLine("updated");
        }


        //private static void GetEmpDetailsWithoutSP()
        //{
        //    var ctx = new LearningContext();
        //    var emp = ctx.Emps.FromSqlRaw("EXECUTE dbo.GetAllDetails").ToList();

        //    foreach (var e in emp)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}


        private static void GetEmpDetailsWithSP()
        {
            var ctx = new LearningContext();
            var emp = ctx.Emps.FromSqlRaw("EXECUTE dbo.GetDetailsByEmpno @p0", 7876).ToList();

            foreach (var e in emp)
            {
                Console.WriteLine(e.Ename);
            }
        }

        //private static void UpdateEmpDetailsSP()
        //{
        //    var ctx = new LearningContext();
        //    try
        //    {
        //        var id = 7900;
        //        string newName = "Reema";
        //        int emp = ctx.Emps.FromSqlRaw("EXECUTE dbo.updatename @p0,@p1", id, newName").ToList();
        //        Console.WriteLine(emp);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //}


        private static void updatename()
        {
            var ctx = new LearningContext();
            var param = new SqlParameter[]
            {
            new SqlParameter() 
            {
            ParameterName = "@empno",
            SqlDbType = System.Data.SqlDbType.Int,
            Size = 100,
            Direction = System.Data.ParameterDirection.Input,
            Value = 7788
            },

            new SqlParameter()
            {
            ParameterName = "@ename",
            SqlDbType = System.Data.SqlDbType.VarChar,
            Size = 100,
            Direction = System.Data.ParameterDirection.Input,
            Value = "Neha",
            }
            //new SqlParameter()
            //{
            //ParameterName = "@deptno",
            //SqlDbType = System.Data.
            //SqlDbType.Decimal,
            //Size = 100,
            //Direction = System.Data.ParameterDirection.Input,
            //Value = 20
            //}
            };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw(" updatename @empno, @ename", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }

            Console.WriteLine("update successful");

        }

    }
}



