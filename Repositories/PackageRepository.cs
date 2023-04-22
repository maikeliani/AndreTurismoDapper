using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private string Conn { get; set; }

        public PackageRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        }
        public List<Package> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var packages = db.Query<Package>(Package.GETALL);
                return (List<Package>)packages;
            }
        }

        public bool Insert(Package package)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Package.INSERT, package);
                status = true;
            }
            return status;
        }
    }
}
