using ScarySpiceDufflinMunder.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    class SalesEmployee : EmployeeBase
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Sales> Sales { get; set; } = new List<Sales>();

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
