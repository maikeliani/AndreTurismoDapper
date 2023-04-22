using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
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
    }
}
