using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;
using Services;

namespace Controllers
{
    public class PackageController
    {
        private PackageService packageService;
        public PackageController()
        {
            packageService = new PackageService();
        }
        public bool Insert(Package package)
        {
            return packageService.Insert(package);
        }

        public List<Package> GetAll()
        {
            return packageService.GetAll();
        }

        public bool Delete(int id)
        {
            return packageService.Delete(id);
        }

        public bool Update(int IdHotel, int IdTicket, double Price, int IdClient, int id)
        {
            return packageService.Update(IdHotel, IdTicket, Price, IdClient, id);
        }



    }
}
