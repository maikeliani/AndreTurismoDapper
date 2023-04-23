using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class HotelController
    {
        private HotelService hotelService;
        public HotelController()
        {
            hotelService = new HotelService();
        }
        public bool Insert(Hotel hotel)
        {
            return hotelService.Insert(hotel);
        }

        public List<Hotel> GetAll()
        {
            return hotelService.GetAll();
        }

        public bool Delete(int id)
        {
            return hotelService.Delete(id);
        }

        public bool Update(string newName, Address newidAdress, double newPrice, int id)
        {
            return hotelService.Update(newName, newidAdress, newPrice, id);
        }

    }
}
