using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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
                string query = Client.INSERT.Replace("@IdAdress", new AddressRepository().InsertAddress(client.Address).ToString());

                db.Execute(query, client);
                status = true;
            }
            return status;
        }
        
        public int InsertClient(Client client)
        {
            string strInsert = "insert into Client (Name, Telephone, IdAdress, Dt_Register) values (@Name, @Telephone, @IdAdress, @Dt_Register); " +
                "select cast(scope_identity() as int)";
            using (var db = new SqlConnection(Conn))
            {
                db.Open();

                string query = strInsert.Replace("@IdAdress", new AddressRepository().InsertAddress(client.Address).ToString());


                return (int)db.ExecuteScalar(query, client);

            }


        }
    }
}
