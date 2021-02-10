using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees;

namespace ScarySpiceDufflinMunder.Employees.Employee
{
    class SalesEmployee : EmployeeBase
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Sales> Sales { get; set; } = new List<Sales>();

        public SalesEmployee(string name)
        {
            Name = name;
        }
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
