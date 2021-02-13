using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees;

namespace ScarySpiceDufflinMunder.Employees.Employee
{
    // SalesEmployee is a derived class of the base class called EmployeeBase.
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
