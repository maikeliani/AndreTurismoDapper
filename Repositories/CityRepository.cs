using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;
using static System.Formats.Asn1.AsnWriter;

namespace Repositories
{

    
    public  class CityRepository : ICityRepository
    {
        private string Conn { get; set; }
        public CityRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public int Insert(City city)
        {
            var id =0;
            using (var db = new SqlConnection(Conn))            {
                
              id =  db.ExecuteScalar<int>(City.INSERT, new {@Description = city.Description, @Dt_Register = city.Dt_Register});                
            }
            return id;
        }


        public List<City> GetAll()
        {
            List<City> list = new List<City>();
            using (var db = new SqlConnection(Conn))
            {
                var cities = db.Query<City>(City.GETALL);
                list = (List<City>)cities;
            }
            return list;
        }

        public bool Delete(int id)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {               
                db.Execute(City.DELETE, new { @Id = id });
                status = true;
            }
            return status;
        }

        public bool Update(City city)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))            {
                db.Open();
                db.Execute(City.UPDATE, new { @Id = city.Id, @Description = city.Description, @Dt_Register = city.Dt_Register });

                status = true;
            }
            return status;
        }

    }
}
