using ScarySpiceDufflinMunder.Employees.Employee;
using System;

namespace ScarySpiceDufflinMunder
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountant1 = new Accounting("Kevin");
            var accountant2 = new Accounting("Oscar");

            Console.WriteLine(@"
               Welcome to Dufflin/Munder Cardboard Co. 
               Sales Portal!
               
               1.Enter Sales
               2.Generate Report For Accountant
               3.Add New Sales Employee
               4.Find a Sale
               5.Exit
                     ");
        }
    }
}
