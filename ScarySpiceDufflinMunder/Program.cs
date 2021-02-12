using ScarySpiceDufflinMunder.Employees.Employee;
using System;
using System.Collections.Generic;

namespace ScarySpiceDufflinMunder
{
    class Program
    {
        public static List<SalesEmployee> SalesEmployees { get; set; } = new List<SalesEmployee>();
        public static List<Accountant> Accountants { get; set; } = new List<Accountant>
        {
            new Accountant("Kevin"),
            new Accountant("Oscar")
        };
        public static List<Client> AllClients { get; set; } = new List<Client>();
        static void Main(string[] args)
        {
            
            while(true)
            {
                UserInterface.MainGreeting();

                var validSelection = int.TryParse(Console.ReadLine(), out int result);
                if (validSelection && result < 5 && result > 0)
                {
                    UserInterface.UserSelection(result);
                }
                else if(result == 5)
                {
                    Console.WriteLine("Thanks for choosing sales portal");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection");
                    continue;
                }
            } 
        }

        public static void AddSalesEmployee(SalesEmployee salesEmployee) => SalesEmployees.Add(salesEmployee);
    }
}
