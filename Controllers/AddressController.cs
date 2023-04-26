using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;
using static System.Formats.Asn1.AsnWriter;

namespace Controllers
{
    public class AddressController
    {
        private AddressService addressService;
        private CityService cityService;
        public AddressController()
        {
            addressService = new AddressService();
            cityService = new CityService();
        }
        public int Insert(Address address)
        {
            var idCity = cityService.Insert(address.City); //  o metodo Insert devolve  um id(int)
            address.City = new City()
            {
                Id = idCity
            };
            return addressService.Insert(address);
        }

        public List<Address> GetAll()
        {
            return addressService.GetAll();
        }
        public bool Delete(int id)
        {
            return addressService.Delete(id);
        }

        
        public bool UpDate(Address address)
        {
            return addressService.UpDate(address);
        }
    }
}
