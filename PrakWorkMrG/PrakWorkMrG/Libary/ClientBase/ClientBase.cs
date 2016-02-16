using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ClientBase
    {
        private List<Client> clietList;
        public Client[] Client
        {
            get
            {
                return clietList.ToArray();
            }
        }
        public ClientBase(Client[] client)
        {
            clietList = client.ToList();
        }
        public bool AddClient(Client client)
        {
            if (client != null && !clietList.Contains(client))
            {
                clietList.Add(client);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteClient(Client client)
        {
            if (client != null && clietList.Contains(client))
            {
                clietList.Remove(client);
                return true;
            }
            else
            {
                return false;
            }
        }
    }

