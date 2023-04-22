﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public class ClientService
    {
        private IClientRepository clientRepository;

        public ClientService()
        {
            clientRepository = new ClientRepository();
        }

        public bool Insert(Client client)
        {
            return clientRepository.Insert(client);
        }

        public List<Client> GetAll()
        {
            return clientRepository.GetAll();
        }
    }
}