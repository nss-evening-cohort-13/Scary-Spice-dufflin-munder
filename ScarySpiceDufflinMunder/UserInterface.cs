using ScarySpiceDufflinMunder.Employees.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    class UserInterface
    {
        
        public static void MainGreeting()
        {
            Console.WriteLine(@"
Welcome to Dufflin/Munder Cardboard Co. 
Sales Portal!

1.Enter Sales
2.Generate Report For Accountant
3.Add New Sales Employee
4.Find a Sale
5.Exit
                     ");
        }
        public static void UserSelection(int caseSwitch)
        {

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Which sales employee are you?");
                    var newSale = new Sales();
                    int count = 1;
                    foreach (var employee in Program.SalesEmployees)
                    {
                        Console.WriteLine($"{count}. {employee.Name}");
                        count++;
                    }
                    var chosenEmployee = int.TryParse(Console.ReadLine(), out int employeeIndex);
                    if (chosenEmployee)
                    {
                        Console.WriteLine($"Hello {Program.SalesEmployees[employeeIndex - 1].Name}!");
                        newSale.EnterSale(Program.SalesEmployees[employeeIndex - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number of an employee.");
                    }
                    
                    break;
                case 2:
                    int counter = 1;
                    Console.WriteLine("Please choose an accountant: either Kevin or Oscar:");
                    var accountName = Console.ReadLine();
                    var accountant = new Accountant(accountName);
                    Console.WriteLine($@"
Monthly Sales Report
For: {accountant.Name}
");
                    foreach (var employee in Program.SalesEmployees)
                    {
                        Console.WriteLine($"{counter}. {employee.Name}");
                        counter++;
                        Report.Create(employee);
                    }
                    
                    break;
                case 3:
                    Console.WriteLine("Please enter a name: ");
                    string newSalesEmployeeName = Console.ReadLine();
                    var newEmployee = new SalesEmployee($"{newSalesEmployeeName}");
                    Program.AddSalesEmployee(newEmployee);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Find a sale by typing in the client ID and hit enter");
                    Console.WriteLine($"Choose from list of clients");
                    // Display all the clientIDs and names
                    foreach (var client in Program.AllClients)
                    {
                        Console.WriteLine($"{client.ClientName}: ClientID {client.ClientID}");
                    }
                    
                    // If ID is valid then show sale
                    while (true)
                    {
                        var userInput = Console.ReadLine();
                        var validClientID = int.TryParse(userInput, out int validID);
                        if (validClientID)
                        {
                            FindSale.ShowSale(validID);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid client ID");
                            continue;
                        }
                        
                    }
                    

                    break;
            }
        }
    }
}
