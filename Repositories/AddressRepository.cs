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
            List<Address> list = new List<Address>();
            using (var db = new SqlConnection(Conn))
            {
                var addresses = db.Query<Address>(Address.GETALL);
                list = (List<Address>)addresses;
            }
            return list;
        }

        public int Insert(Address address)
        {
            var id = 0;
            using (var db = new SqlConnection(Conn))
            {              
              id =  db.ExecuteScalar<int>(Address.INSERT, new { @Street = address.Street, @Number = address.Number, @Neighborhood = address.NeighborHood, @ZipCode = address.ZipCode, @Complement = address.Complement, @IdCity = address.City.Id, @Dt_Register = address.Dt_Register });               
                
            }
            return id;
        }
       


        public bool Delete(int id)
        {
             var status = false;
            
            using (var db = new SqlConnection(Conn))
            {                               
                db.Execute(Address.DELETE, new {@Id = id});
                status = true;
            }
            return status;
        }


        public bool Update(Address address)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {                                                    
                db.Execute(Address.UPDATE, new { @Id = address.Id ,@Street = address.Street, @Number = address.Number, @NeighborHood = address.NeighborHood, @ZipCode = address.ZipCode, @Complement = address.Complement, @IdCity = address.City.Id, @DtRegisterAddress = address.Dt_Register });
                status = true;
            }
            return status;
        }
    }
}
