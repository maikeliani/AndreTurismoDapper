using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public  class HotelService
    {
        private IHotelRepository hotelRepository;

        public HotelService()
        {
            hotelRepository = new HotelRepository();
        }

        public bool Insert(Hotel hotel)
        {
            return hotelRepository.Insert(hotel);
        }

        public List<Hotel> GetAll()
        {
            return hotelRepository.GetAll();
        }

        public bool Delete(int id)
        {
            return hotelRepository.Delete(id);
        }
    }
}
