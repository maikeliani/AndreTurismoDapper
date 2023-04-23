using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class ClientController
    {
        private ClientService clientService;
        public ClientController()
        {
            clientService = new ClientService();
        }
        public bool Insert(Client client)
        {
            return clientService.Insert(client);
        }

        public List<Client> GetAll()
        {
            return clientService.GetAll();
        }

        public bool Delete(int  id)
        { 
            return clientService.Delete(id);
        }
    }
}