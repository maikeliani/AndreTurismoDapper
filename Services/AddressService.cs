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

        public bool Insert(Address address)
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

        public bool UpDate(string newStreet, int newNumber, string newNeighborHood, string newZipCode, string newComplement, int id)
        {
            return addressRepository.Update(newStreet, newNumber, newNeighborHood, newZipCode, newComplement, id);
        }


    }
}
