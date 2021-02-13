using ScarySpiceDufflinMunder.Employees.Employee;
using System;
using System.Collections.Generic;

namespace ScarySpiceDufflinMunder
{
        /********
         ******** Scary Spice Dunder Mifflin Console App
         ******** Description: This is the main class of Scary Spice Dunder Mifflin. This is a console
         ******** Application that allows users to simulate a client / sales report for sales employees
         ******** they enter through the application. The UI gives the user the choice to enter a new
         ******** Salesemployee, Enter a sale, Generate a report, and Find Sales for a particular client
         ******** they entered
         ******** This was created as a group assignment through Nashville Software School.
         ********/
    class Program
    {
        // Llist to hold SalesEmployees
        public static List<SalesEmployee> SalesEmployees { get; set; } = new List<SalesEmployee>();
        // List to hold Accountant Names
        public static List<Accountant> Accountants { get; set; } = new List<Accountant>
        {
            new Accountant("Kevin"),
            new Accountant("Oscar")
        };
        
        // List to hold Clients
        public static List<Client> AllClients { get; set; } = new List<Client>();

        // Static function that adds a new employee into the list of SalesEmployees
        // Takes one argument: saleEmployee
        public static void AddSalesEmployee(SalesEmployee salesEmployee) => SalesEmployees.Add(salesEmployee);
        
        // Main Class
        static void Main(string[] args)
        {
            // Main loop will run until the exit option [5] is selected

            while(true)
            {
                // Greets the user and requests them enter a choice of action
                UserInterface.MainGreeting();
                // Checks user input and assigns user input to a variable
                var validSelection = int.TryParse(Console.ReadLine(), out int result);
                // Control flow for user selection
                if (validSelection && result < 5 && result > 0)
                {
                    // Enters a switch statement (in UserInterface class) for the user's selection
                    UserInterface.UserSelection(result);
                }
                else if(result == 5)
                {
                    // Thanks the user and breaks out of the program
                    Console.WriteLine("Thanks for choosing sales portal");
                    break;
                }
                else
                {
                    //Lets the user know input was invalid and requests another input
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection");
                    continue;
                }
            } 
        }
    }
}
