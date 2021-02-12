using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees.Employee;
using System.Linq;

namespace ScarySpiceDufflinMunder
{
    class FindSale : Sales
    {
         
        public static void ShowSale(int userInput)
        {
            
            var matchedID = Program.AllClients.Where(client => client.ClientID == userInput).ToList();
            if(!matchedID.Any())
            {
                Console.WriteLine($"There are no Clients with that ID.");
            }
            else
            {
                var clientID = userInput;
                Console.WriteLine();
                
                    Console.WriteLine($"Sales for the ClientID: {clientID}");
                foreach (var salesEmployee in Program.SalesEmployees)
                {
                    foreach (var sale in salesEmployee.Sales)
                    {
                        if(clientID == sale.ClientId)
                        {
                            Console.WriteLine($@"
    Sales Agent: {salesEmployee.Name}
    Client: {sale.ClientName}
    ClientID: {sale.ClientId}
    Sale: ${sale.Sale}
    Recurring: {sale.Recurring}
    Time Frame: {sale.TimeFrame} month(s)
");
                        }
                        

                    }
                }
                    
            }


        }
    }
}
