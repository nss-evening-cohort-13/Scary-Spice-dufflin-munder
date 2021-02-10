using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees.Employee;

namespace ScarySpiceDufflinMunder
{
    class Report
    {

        public static void Create()
        {
            Console.WriteLine("Please choose an accountant: either Kevin or Oscar:");
            var accountName = Console.ReadLine();
            var accountant = new Accountant(accountName);

            var SalesEmployees = new List<SalesEmployee>()
            {
                new SalesEmployee("John"),
                new SalesEmployee("Peggy"),
                new SalesEmployee("Sue")
            };

            Console.WriteLine($@"
Monthly Sales Report
For: {accountant.Name}
");

            int number = 1;
    foreach(var salesEmployee in SalesEmployees)
            {
                Console.WriteLine();
                Console.WriteLine($"{number}.{salesEmployee.Name}");
                Console.WriteLine("Clients: ");
                // Loop over the employees Clients:
                Console.WriteLine($@"
1. Carol's Pen Pals
2. 2 Men & A Horse Moving Co
3. Taco Hell Distrubuting ");
                Console.WriteLine("Total: $12,234.20");
               
                number++;
            }
            

        }
    }
}
