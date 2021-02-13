using System;
using System.Collections.Generic;
using System.Text;

namespace ScarySpiceDufflinMunder
{
    /********
         ******** Client Class
         ******** This class contains the clients name and client ID 
         ********/
    class Client
    {
        // properties
        public string ClientName { get; set; }
        public int ClientID { get; set; }

        // constructor
        public Client(string clientName, int clientID)
        {
            ClientName = clientName;
            ClientID = clientID;
        }
    }
}
