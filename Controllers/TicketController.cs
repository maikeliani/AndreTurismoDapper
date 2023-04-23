using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class TicketController
    {
        private TicketService ticketService;
        public TicketController()
        {
            ticketService = new TicketService();
        }
        public bool Insert(Ticket ticket)
        {
            return ticketService.Insert(ticket);
        }

        public List<Ticket> GetAll()
        {
            return ticketService.GetAll();
        }

        public bool Delete(int id)
        { 
            return ticketService.Delete(id);
        }

        public bool UpDate(Address idSourceAddress, Address idDestinationAddress, Client idClient, double price, int id)
        {
            return ticketService.UpDate(idSourceAddress, idDestinationAddress, idClient, price, id);
        }

    }
}
