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
        public AddressController()
        {
            addressService = new AddressService();
        }
        public bool Insert(Address address)
        {
            return addressService.Insert(address);
        }

        public List<Address> GetAll()
        {
            return addressService.GetAll();
        }
    }
}
