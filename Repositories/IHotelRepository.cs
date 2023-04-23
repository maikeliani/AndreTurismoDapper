using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using static System.Formats.Asn1.AsnWriter;

namespace Repositories
{
    public interface IHotelRepository
    {
        bool Insert(Hotel hotel);

        List<Hotel> GetAll();
        bool Delete(int id);
        bool Update(string newName, Address newidAdress, double newPrice, int id);
    }
}
