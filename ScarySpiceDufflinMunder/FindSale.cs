using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees.Employee;
using System.Linq;

namespace ScarySpiceDufflinMunder
{
    class FindSale : Sales
    {
         
        public static void ShowSale(SalesEmployee salesEmployee)
        {
            var userInput = int.Parse(Console.ReadLine());
            var matchedID = salesEmployee.Clients.Where(client => client.ClientID == userInput).ToList();
            if(!matchedID.Any())
            {
                var client = matchedID.Count;
                Console.WriteLine($"The client ID you entered does not match any sale");
            }
            else
            {
                var client = matchedID[0].ClientID;
                Console.WriteLine($"{userInput} should match {client}");
            }


        }
    }
}
