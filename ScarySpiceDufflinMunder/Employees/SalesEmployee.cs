using ScarySpiceDufflinMunder.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    class SalesEmployee : EmployeeBase
    {
        private List<Client> Clients { get; set; } = new List<Client>();
        private List<Sales> Sales { get; set; } = new List<Sales>();

        // Constructor
        public SalesEmployee(string name)
        {
            Name = name;
        }
        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
        public void AddSale(Sales sale)
        {
            Sales.Add(sale);
        }
        public List<Client> getEmployeeClients()
        {
            return Clients;
        }
        public List<Sales> getEmployeeSales()
        {
            return Sales;
        }
    }
}
