using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees.Employee;

namespace ScarySpiceDufflinMunder
{
    class Report
    {

        public static void Create(SalesEmployee employee)
        {
            
            Console.WriteLine();
            Console.WriteLine("Clients: ");
            int number = 1;
            double total = 0;
            
    foreach(var client in employee.Clients)
            {
                // Loop over the employees Clients:
                Console.WriteLine($@"     {number}. {client.ClientName}");
                number++;
            }
            
            employee.Sales.ForEach(sales =>
            {
                if (sales.TimeFrame >= 1)
                {
                    total += sales.Sale * sales.TimeFrame;
                } else
                {
                    total += sales.Sale;
                }
               
                
                
            });
            Console.WriteLine($@"Total: {total}");




        }
    }
}
