using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    class SalesEmployee
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Sale> Sales { get; set; } = new List<Sale>();

        public void AddClient (Client client)
        {
            Clients.Add(client);
        }
        public void AddSale(Sale sale)
        {
            Sales.Add(sale);
        }

    }
}
