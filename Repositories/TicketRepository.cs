using System;
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
    public class TicketRepository : ITicketRepository
    {
        private string Conn { get; set; }

        public TicketRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        }

        public bool Insert(Ticket ticket)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();                

                SqlCommand commandInsert = new SqlCommand(Ticket.INSERT, db);

                commandInsert.Parameters.Add(new SqlParameter("@SourceAdress", new AddressRepository().InsertAddress(ticket.SourceAddress).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@DestinationAdress", new AddressRepository().InsertAddress(ticket.DestinationAddress).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@IdClient", new ClientRepository().InsertClient(ticket.Client).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@Dt_Register", ticket.Dt_Register));
                commandInsert.Parameters.Add(new SqlParameter("@Price", ticket.Price));
                commandInsert.ExecuteNonQuery();
              
                status = true;
            }
            return status;
        }


        public int InsertTicket(Ticket ticket)
        {
            using (var db = new SqlConnection(Conn))
            {
                
                db.Open();
                string strInsert = "insert into Ticket " +
                "(SourceAdress, DestinationAdress , IdClient, Dt_Register, Price)" +
                " values (@SourceAdress, @DestinationAdress, @IdClient, @Dt_Register, @Price); " +
                "select cast(scope_identity() as int)";
                SqlCommand commandInsert = new SqlCommand(strInsert, db);
                commandInsert.Parameters.Add(new SqlParameter("@SourceAdress", new AddressRepository().InsertAddress(ticket.SourceAddress).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@DestinationAdress", new AddressRepository().InsertAddress(ticket.DestinationAddress).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@IdClient", new ClientRepository().InsertClient(ticket.Client).ToString()));
                commandInsert.Parameters.Add(new SqlParameter("@Dt_Register", ticket.Dt_Register));
                commandInsert.Parameters.Add(new SqlParameter("@Price", ticket.Price));
                return (int)commandInsert.ExecuteScalar();
            }
        }


        public List<Ticket> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var tickets = db.Query<Ticket>(Ticket.GETALL);
                return (List<Ticket>)tickets;
            }
        }
    }
}
