using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using static System.Formats.Asn1.AsnWriter;

namespace Repositories
{
    public interface IAddressRepository
    {
        int Insert(Address address);

        List<Address> GetAll();
        bool Delete(int id);
        bool Update(Address address);
    }
}
