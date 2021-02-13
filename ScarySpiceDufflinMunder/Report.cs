using ScarySpiceDufflinMunder.Employees.Employee;
using System;

namespace ScarySpiceDufflinMunder
{
    class Report
    {
        /********
         ******** Report Create
         ******** Description: This class will generate a report that loops through each
         ******** Client name and then displays a total of sales.
         ******** Arguments: Takes one SalesEmployee Object
         ********/
        public static void Create(SalesEmployee employee)
        {
            // variables to hold number of clients and totals
            int number = 1;
            double total = 0;
            // Display Clients Header
            Console.WriteLine("Clients: ");
            // Loops over SalesEmployee Clients and displays the number followed by name:
            foreach (var client in employee.Clients)
            {
                
                Console.WriteLine($@"     {number}. {client.ClientName}");
                number++;
            }
            // Loops over the SalesEmployees sales and adds to the total variable
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
            // Displays the total in the total variable:
            Console.WriteLine($@"Total: {total}");
        }
    }
}
