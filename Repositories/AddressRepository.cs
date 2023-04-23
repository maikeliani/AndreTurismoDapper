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
    public class AddressRepository : IAddressRepository
    {
        private string Conn { get; set; }

        public AddressRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        }
        public List<Address> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var addresses = db.Query<Address>(Address.GETALL);
                return (List<Address>)addresses;
            }
        }

        public bool Insert(Address address)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                string query = Address.INSERT.Replace("@IdCity",new CityRepository().InsertCity(address.City).ToString());
                db.Execute(query,address);
                status = true;
            }
            return status;
        }

        public int InsertAddress(Address address)
        {
            string strInsert = "insert into Adress " +
                "(Street, Number, NeighborHood, ZipCode, Complement, IdCity, Dt_Register)" +
                " values (@Street, @Number, @NeighborHood, @ZipCode, @Complement, @IdCity , @Dt_Register ); " +
                "select cast(scope_identity() as int)";
            using (var db = new SqlConnection(Conn))
            {   
                db.Open();

                string query = strInsert.Replace("@IdCity", new CityRepository().InsertCity(address.City).ToString());


                return (int)db.ExecuteScalar(query, address);
                
            }
            
        }


        public bool Delete(int id)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Address.DELETE + id);
                status = true;
            }
            return status;
        }





    }
}
