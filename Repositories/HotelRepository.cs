using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private string Conn { get; set; }
        public HotelRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public bool Insert(Hotel hotel)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                string query = Hotel.INSERT.Replace("@IdAdress", new AddressRepository().InsertAddress(hotel.Address).ToString());

                db.Execute(query, hotel);
                status = true;
            }
            return status;
        }


        public int InsertHotel(Hotel hotel)
        {           
                string strInsert = "insert into Hotel " +
                "(Name, IdAdress , Dt_Register, Price) " +
                "values (@Name, @IdAdress, @Dt_Register, @Price); " +
            "select cast(scope_identity() as int)";

            using (var db = new SqlConnection(Conn))
            {
                db.Open();

                var query = strInsert.Replace("@IdAdress", new AddressRepository().InsertAddress(hotel.Address).ToString());

                return (int)db.ExecuteScalar(query, hotel);

            }
        
        }

        public List<Hotel> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var hotels = db.Query<Hotel>(Hotel.GETALL);
                return (List<Hotel>)hotels;
            }
        }
    }
}
