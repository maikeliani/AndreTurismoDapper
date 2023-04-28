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
        public int Insert(Package package)
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

        public bool Update(Package package)
        {
            return packageService.Update(package);
        }



    }
}
