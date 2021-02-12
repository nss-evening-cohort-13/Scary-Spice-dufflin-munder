using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees.Employee;
using System.Linq;

namespace ScarySpiceDufflinMunder
{
    class FindSale : Sales
    {
         
        public static void ShowSale(int userInput, SalesEmployee salesEmployee)
        {
            
            var matchedID = salesEmployee.Clients.Where(client => client.ClientID == userInput).ToList();
            if(!matchedID.Any())
            {
                Console.WriteLine($"The client ID you entered does not match any sale");
            }
            else
            {
                var clientID = matchedID[0].ClientID;
                Console.WriteLine();
                if(userInput == clientID)
                {
                    Console.WriteLine($"Sales for the ClientID: {clientID}");
                    foreach (var sale in salesEmployee.Sales)
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
