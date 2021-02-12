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
                Console.WriteLine($@"{number}. {client.ClientName}");
                number++;
            }
            foreach (var sales in employee.Sales)
            {
                // Loop over the employees Sales:
                total += sales.Sale;
                
            }
            Console.WriteLine($@"Total: {total}");



        }
    }
}
