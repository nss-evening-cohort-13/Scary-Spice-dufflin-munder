using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    class Sales
    {
        public string ClientName { get; }
        public int ClientId { get; }
        public double Sale { get; set; }
        public bool Recurring { get; set; }
        public int TimeFrame { get; set; }

        public Sales(Client client, double sale, bool recurring, int timeFrame)
        {
            ClientName = client.ClientName;
            ClientId = client.ClientID;
            Sale = sale;
            Recurring = recurring;
            TimeFrame = timeFrame;
        }
    }
}
