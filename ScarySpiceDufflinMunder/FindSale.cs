using System;
using System.Linq;

namespace ScarySpiceDufflinMunder
{
    class FindSale : Sales
    {
        /********
         ******** Find A Sale
         ******** This class will take in the valid user input and find the clientID that matches
         ******** If the ID matches then it will display the sale
         ********/

        public static void ShowSale(int userInput)
        {
            Console.Clear();
            // find the clientID matching userInput
            var matchedID = Program.AllClients.Where(client => client.ClientID == userInput).ToList();

            // if there is no match then display statement
            if(!matchedID.Any())
            {
                Console.WriteLine($"There are no Clients with that ID.");
            }
            else
            {
                // clientID matched user input and is set to variable 
                var clientID = userInput;
                Console.WriteLine();
                
                    Console.WriteLine($"Sales for the ClientID: {clientID}");
                // find the sales that each employee has and display the sale matching the clientID
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
