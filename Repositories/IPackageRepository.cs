using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using static System.Formats.Asn1.AsnWriter;

namespace Repositories
{
    public  interface IPackageRepository
    {
        int Insert(Package package);

        List<Package> GetAll();
        bool Delete(int id);
        bool UpDate(Package package);
    }
}
