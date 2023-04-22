﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Repositories
{
    public class ClientRepository : IClientRepository
    {
        private string Conn { get; set; }

        public ClientRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        }
        public List<Client> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var clients = db.Query<Client>(Client.GETALL);
                return (List<Client>)clients;
            }
        }

        public bool Insert(Client client)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Client.INSERT, client);
                status = true;
            }
            return status;
        }
    }
}
