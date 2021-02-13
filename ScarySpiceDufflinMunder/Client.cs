namespace ScarySpiceDufflinMunder
{
    /********
     ******** Client Class
     ******** Description: This class contains the clients name and client ID 
     ******** Arguments: takes string clientName, and int clientID
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
