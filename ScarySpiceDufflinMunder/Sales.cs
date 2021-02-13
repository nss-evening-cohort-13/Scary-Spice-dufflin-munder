using ScarySpiceDufflinMunder.Employees.Employee;
using System;
using System.Linq;

namespace ScarySpiceDufflinMunder
{
    class Sales
    {
        /********
         ******** Add a Sale
         ******** Description: This class will generate a sale based on user input.
         ******** This sale is used in the Report and Find a Sale features
         ******** Arguments: Takes one SalesEmployee Object
         ********/
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public double Sale { get; set; }
        public string Recurring { get; set; }
        public int TimeFrame { get; set; }

        public void EnterSale(SalesEmployee salesEmployee)
        {
            var randomId = new Random();
            Console.WriteLine("Please enter a Client ID or add a new client by typing out the client's name.");
            var clientInfo = Console.ReadLine();
            //this checks if the user inputs an integer or a string
            var validId = int.TryParse(clientInfo, out int clientId);
            if (validId)
            {
                //this checks all clients to see if the integer enetered matches a Client ID in the database
                 var gottenClient = Program.AllClients.Where(client => client.ClientID == clientId).ToList();
                if (!gottenClient.Any())
                {
                    //this creates a new client if no Client ID matches the integer entered
                    Console.WriteLine("Client ID not found. Please enter the Client's name.");
                    var clientName = Console.ReadLine();
                    Program.AllClients.Add(new Client(clientName.ToString(), clientId));
                    salesEmployee.AddClient(new Client(clientName.ToString(), clientId));
                    ClientName = clientName;
                    ClientId = clientId;
                }
                else
                {
                    //this takes the existing client based on the client ID and adds the name and ID as a property
                    ClientName = gottenClient[0].ClientName;
                    ClientId = gottenClient[0].ClientID;
                }

            }
            //this section creates a new client with the client name of the string entered
            else
            {
                while(true)
                {
                    //this assigns a random integer as the new client ID and checks if any existing IDs match the random integer
                    var randomClientId = randomId.Next(1, 50000);
                    var preventDupes = Program.AllClients.Where(client => client.ClientID == randomClientId).ToList();
                    if (!preventDupes.Any())
                    {
                        //if none match, it creates a new client with that client ID, else it generates a new random integer
                        Program.AllClients.Add(new Client(clientInfo, randomClientId));
                        salesEmployee.AddClient(new Client(clientInfo, randomClientId));
                        ClientName = clientInfo;
                        ClientId = randomClientId;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            while (true)
            {
                //this takes the user's sale input and checks if it's a valid number, if not it asks them to enter a valid number
                Console.WriteLine("Please enter the sale amount.");
                var checkSale = Console.ReadLine();
                var validSale = double.TryParse(checkSale, out double saleAmount);
                if (validSale)
                {
                    Sale = saleAmount;
                    break;
                }
                else
                {
                    Console.WriteLine("Input not valid. Please enter the sale amount using the numbers on your keyboard.");
                    continue;
                }
            }
            while (true)
            {
                //this checks if the payment is recurring or not. if not, it will add a sale with the current properties
                Console.WriteLine("Is this a recurring payment? Press Y or N");
                var recurring = Console.ReadLine();
                if (recurring.ToLower() == "n")
                {
                    Recurring = "One-Time";
                    TimeFrame = 1;
                    salesEmployee.AddSale(new Sales()
                    { ClientName = ClientName, ClientId = ClientId, Sale = Sale, Recurring = Recurring, TimeFrame = TimeFrame });
                    break;
                }
                //this asks how many months the payment will be recurring for, then adds a sale with the current properties
                else if (recurring.ToLower() == "y")
                {
                    while (true)
                    {
                        Console.WriteLine("How many months will this payment be recurring?");
                        var checkMonthly = Console.ReadLine();
                        var validMonthly = int.TryParse(checkMonthly, out int monthlyPayment);

                        if (validMonthly)
                        {
                            Recurring = "Monthly";
                            TimeFrame = monthlyPayment;
                            salesEmployee.AddSale(new Sales()
                            { ClientName = ClientName, ClientId = ClientId, Sale = Sale, Recurring = Recurring, TimeFrame = TimeFrame });
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter how many months this payment will be recurring using the numbers on your keyboard.");
                            continue;
                        }
                        
                    }
                    break;                    
                }
                else
                {
                    Console.WriteLine("Input not valid. Please type Y or N.");
                    continue;
                }
            }
            //this clears out the console then prints the sales details to the console.
            Console.Clear();
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
