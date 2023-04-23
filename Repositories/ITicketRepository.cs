using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using static System.Formats.Asn1.AsnWriter;

namespace Repositories
{
    public interface ITicketRepository
    {
        bool Insert(Ticket ticket);

        List<Ticket> GetAll();
        bool Delete(int id);
    }
}
