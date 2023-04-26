using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;
using static System.Formats.Asn1.AsnWriter;

namespace Services
{
    public  class AddressService
    {
        private IAddressRepository addressRepository;

        public AddressService()
        {
            addressRepository = new AddressRepository();
        }

        public int Insert(Address address)
        {
            return addressRepository.Insert(address);
        }

        public List<Address> GetAll()
        {
            return addressRepository.GetAll();
        }

        public bool Delete(int  id)
        {
            return addressRepository.Delete(id);
        }

        public bool UpDate(Address address)
        {
            return addressRepository.Update(address);
        }


    }
}
