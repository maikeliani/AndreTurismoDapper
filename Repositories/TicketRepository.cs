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
                db.Execute(Ticket.INSERT, ticket);
                status = true;
            }
            return status;
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
