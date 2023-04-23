using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public  class TicketService
    {
        private ITicketRepository ticketRepository;

        public TicketService()
        {
            ticketRepository = new TicketRepository();
        }

        public bool Insert(Ticket ticket)
        {
            return ticketRepository.Insert(ticket);
        }

        public List<Ticket> GetAll()
        {
            return ticketRepository.GetAll();
        }

        public bool Delete(int id)
        {
            return ticketRepository.Delete(id);
        }

        public bool UpDate(Address idSourceAddress, Address idDestinationAddress, Client idClient, double price, int id)
        {
            return ticketRepository.Update(idSourceAddress, idDestinationAddress, idClient, price, id);
        }

    }
}
