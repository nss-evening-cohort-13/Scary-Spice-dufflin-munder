using ScarySpiceDufflinMunder.Employees.Employee;
using System;

namespace ScarySpiceDufflinMunder
{
    class UserInterface
    {
        /********
 ******** User Interface
 ******** Description: This class houses the user interface to navigate throughout
 ******** the various features of the console application.
 ********/
        public static void MainGreeting()
        {
            Console.WriteLine(@"
Welcome to Dufflin/Munder Cardboard Co. 
Sales Portal!

1. Enter Sales
2. Generate Report For Accountant
3. Add New Sales Employee
4. Find a Sale
5. Exit
");
        }

        public static void UserSelection(int caseSwitch)
        {
            Console.Clear();
            switch (caseSwitch)
            {
                // Feature 1: Enter a sale
                case 1:
                    Console.WriteLine("Which sales employee are you?");
                    var newSale = new Sales();
                    int count = 1;

                    // Print out a list of existing employees.
                    foreach (var employee in Program.SalesEmployees)
                    {
                        Console.WriteLine($"{count}. {employee.Name}");
                        count++;
                    }

                    // Require user to enter index associated with employee
                    while (true)
                    {
                        var chosenEmployee = int.TryParse(Console.ReadLine(), out int employeeIndex);
                        if (chosenEmployee)
                        {
                            Console.WriteLine($"Hello {Program.SalesEmployees[employeeIndex - 1].Name}!");
                            // Call EnterSale method on newSale object using selected employee index
                            newSale.EnterSale(Program.SalesEmployees[employeeIndex - 1]);
                            break;
                        }
                        // Account for invalid input
                        else
                        {
                            Console.WriteLine("Please enter a valid number of an employee.");
                            continue;
                        }
                    }    
                    
                    break;

                // Feature 2: Generate report for accountant
                case 2:
                    int counter = 1;
                    Console.WriteLine("Please enter your accountant's name. Either \"Oscar\" or \"Kevin\": ");
                    var accountName = Console.ReadLine();
                    var accountant = new Accountant(accountName);
                    Console.WriteLine($@"
Monthly Sales Report
For: {accountant.Name}
");
                    // Loop through all employees
                    foreach (var employee in Program.SalesEmployees)
                    {
                        Console.WriteLine($"{counter}. {employee.Name}");
                        counter++;
                        // Create report for current employee
                        Report.Create(employee);
                    }
                    
                    break;

                // Feature 3: Create new employee
                case 3:
                    Console.WriteLine("Please enter an employee name: ");
                    string newSalesEmployeeName = Console.ReadLine();
                    // Create new employee using name input from user
                    var newEmployee = new SalesEmployee($"{newSalesEmployeeName}");
                    Program.AddSalesEmployee(newEmployee);
                    break;

                // Feature 4: Find a sale
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
