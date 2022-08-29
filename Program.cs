// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, Github!");

using Batch1_DET_2022;

class myclass
{
    enum grade { pass = 60, distinction = 85 };
    //method that returns grade based on the mark

    public static void getgrade(int mark) { } //in parameter
    public static void main()
    {
        #region "containment"
        CompanyManager m = new CompanyManager { Name = "Chaitra", Surname = "K", PhoneNo = "9654869852" };
        Company company = new Company { Name = "ssl", Address = "global city", Manager = m, PhoneNo = "9658748965", Website = "ssl.com" };

        Console.WriteLine(company.Print());
        #endregion
        //manager m = new manager(6469,"chaitra",new datetime(2006,6,5),"tech",10); //default

    }
}
