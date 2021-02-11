using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ScarySpiceDufflinMunder.Employees.Employee;

namespace ScarySpiceDufflinMunder
{
    class Sales
    {
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public double Sale { get; set; }
        public string Recurring { get; set; }
        public int TimeFrame { get; set; }

        public void EnterSale(SalesEmployee salesEmployee)
        {
            var randomId = new Random();
            Console.WriteLine("Please submit a Client ID. If this is a new Client, please enter the Client's name.");
            var clientInfo = Console.ReadLine();
            var validId = int.TryParse(clientInfo, out int clientId);
            if (validId)
            {
                 var gottenClient = salesEmployee.Clients.Where(client => client.ClientID == clientId).ToList();
                if (!gottenClient.Any())
                {
                    Console.WriteLine("Client ID not found. Please enter the Client's name.");
                    var clientName = Console.ReadLine();
                    salesEmployee.AddClient(new Client(clientName.ToString(), clientId));
                    ClientName = clientName;
                    ClientId = clientId;
                }
                else
                {
                    ClientName = gottenClient[0].ClientName;
                    ClientId = gottenClient[0].ClientID;
                }

            }
            else
            {
                var randomClientId = randomId.Next(1, 50000);
                salesEmployee.AddClient(new Client(clientInfo, randomClientId));
                ClientName = clientInfo;
                ClientId = randomClientId;
            }
            Console.WriteLine("Please enter the sale amount.");
            var saleAmount = Console.ReadLine();
            Console.WriteLine("Is this a recurring payment? Press Y or N");
            var recurring = Console.ReadLine();
            if (recurring == "N".ToLower())
            {
                Sale = double.Parse(saleAmount);
                Recurring = "One-Time";
                TimeFrame = 1;
                salesEmployee.AddSale(new Sales());
            }
            else
            {
                Console.WriteLine("How many months will this payment be recurring?");
                var monthlyPayment = Console.ReadLine();
                Sale = double.Parse(saleAmount);
                Recurring = "Monthly";
                TimeFrame = int.Parse(monthlyPayment);
                salesEmployee.AddSale(new Sales());
            }
            Console.WriteLine($@"
Sale completed! Details below:

Sales Agent: {salesEmployee.Name}
Client: {ClientName}
ClientID: {ClientId}
Sale: ${Sale}
Recurring: {Recurring}
Time Frame: {TimeFrame} month(s)
");
        }
    }
}
