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
                    var chosenEmployee = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Hello {Program.SalesEmployees[chosenEmployee - 1].Name}!");
                    newSale.EnterSale(Program.SalesEmployees[chosenEmployee - 1]);
                    break;
                case 2:
                    Report.Create();
                    break;
                case 3:
                    Console.WriteLine("Please enter a name: ");
                    string newSalesEmployeeName = Console.ReadLine();
                    var newEmployee = new SalesEmployee($"{newSalesEmployeeName}");
                    Program.AddSalesEmployee(newEmployee);
                    //print all of employees just to check
                    //foreach(var employee in Program.SalesEmployees)
                    //{
                    //    Console.WriteLine($"{employee.Name}");
                    //}
                    break;
                case 4:

                    Console.WriteLine("Find a sale by typing in the client ID and hit enter");
                    FindSale.ShowSale(Program.SalesEmployees[0]);

                    break;
            }
        }
    }
}
