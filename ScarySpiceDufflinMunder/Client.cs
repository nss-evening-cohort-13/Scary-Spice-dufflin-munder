using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    class Client
    {
        public string ClientName { get; set; }
        public int ClientID { get; set; }

        public Client(string clientName, int clientID)
        {
            ClientName = clientName;
            ClientID = clientID;
        }
    }
}
