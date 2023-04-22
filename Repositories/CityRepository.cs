using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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

        public bool Insert(City city)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(City.INSERT, city);
                status = true;
            }
            return status;
        }

        public int InsertCity(City city)
        {
            string strInsert = "insert into City (Description, Dt_Register) values (@Description, @Dt_Register ); " +
                "select cast(scope_identity() as int)";
            using (var db = new SqlConnection(Conn))
            {
                db.Open();                
                return (int)db.ExecuteScalar(strInsert, city);

            }

            

        }


        public List<City> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var cities = db.Query<City>(City.GETALL);
                return (List<City>)cities;
            }
        }

        public bool Delete(int id)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(City.DELETE + id);
                status = true;
            }
            return status;
        }

    }
}
