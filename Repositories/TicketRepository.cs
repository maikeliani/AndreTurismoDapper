﻿using System;
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
    public class TicketRepository : ITicketRepository
    {
        private string Conn { get; set; }

        public TicketRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        }

        public int Insert(Ticket ticket)
        {
            var id = 0;
            using (var db = new SqlConnection(Conn))
            {
                id = db.ExecuteScalar<int>(Ticket.INSERT, new {@SourceAdress = ticket.SourceAddress.Id, @DestinationAdress = ticket.DestinationAddress.Id, @IdClient = ticket.Client.Id, @Dt_Register = ticket.Dt_Register, @Price = ticket.Price});
            }
            return id;
        }

        public List<Ticket> GetAll()
        {
            List<Ticket> list = new List<Ticket>();
            using (var db = new SqlConnection(Conn))
            {
                var tickets = db.Query<Ticket>(Ticket.GETALL);
                list = (List<Ticket>)tickets;
            }
            return list;
        }


        public bool Delete(int id)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Execute(Ticket.DELETE, new { @Id = id });
                status = true;
            }
            return status;
        }

        public bool Update(Ticket ticket)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {               
                db.Execute(Ticket.UPDATE, new { @Id = ticket.Id, @SourceAdress = ticket.SourceAddress.Id, @DestinationAdress = ticket.DestinationAddress.Id, @IdClient = ticket.Client.Id, @Dt_Register = ticket.Dt_Register, @Price = ticket.Price });

                status = true;
            }
            return status;
        }



    }


}
