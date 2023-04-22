using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private string Conn { get; set; }

        public PackageRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        }
        public List<Package> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var packages = db.Query<Package>(Package.GETALL);
                return (List<Package>)packages;
            }
        }

        public bool Insert(Package package)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                SqlCommand commandInsert = new SqlCommand(Ticket.INSERT, db);

                commandInsert.Parameters.Add(new SqlParameter("@IdHotel", new HotelRepository().InsertHotel(package.Hotel).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@IdTicket", new TicketRepository().InsertTicket(package.Ticket).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@Dt_Register", package.Dt_Register));
                commandInsert.Parameters.Add(new SqlParameter("@Price", package.Price));
                commandInsert.Parameters.Add(new SqlParameter("@IdClient", new ClientRepository().InsertClient(package.Client).ToString()));

                commandInsert.ExecuteNonQuery();
                
                status = true;
            }
            return status;
        }
    }
}
