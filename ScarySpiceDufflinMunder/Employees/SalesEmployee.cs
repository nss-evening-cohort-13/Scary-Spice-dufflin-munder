using System.Collections.Generic;

namespace ScarySpiceDufflinMunder.Employees.Employee
{
    /********
    ******** SalesEmployee
    ******** SalesEmployee is a derived class of the base class called EmployeeBase.
    ******** This class has 2 lists to contain the SalesEmployees Clients and Sales,
    ******** and contains methods to add to those lists
    ******** Arguments: takes one argument: string name
    ********/
    class SalesEmployee : EmployeeBase
    {
        // Properties
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Sales> Sales { get; set; } = new List<Sales>();

        // Constructor
        public SalesEmployee(string name)
        {
            Name = name;
        }

        // Methods
        public void AddClient (Client client)
        {
            Clients.Add(client);
        }
        public void AddSale(Sales sale)
        {
            Sales.Add(sale);
        }

    }
}
