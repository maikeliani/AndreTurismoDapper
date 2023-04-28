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

        public int Insert(Hotel hotel)
        {
            var id = 0;
            using (var db = new SqlConnection(Conn))
            {
                id = db.ExecuteScalar<int>(Hotel.INSERT, new { @Name = hotel.Name, @IdAdress = hotel.Address.Id, @Dt_Register = hotel.Dt_Register, @Price = hotel.Price });
            }
            return id;
        }


        public bool Delete(int id)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Execute(Hotel.DELETE, new { @Id = id });
                status = true;
            }
            return status;
        }

        public List<Hotel> GetAll()
        {
            List<Hotel> list = new List<Hotel>();
            using (var db = new SqlConnection(Conn))
            {
                var hotels = db.Query<Hotel>(Hotel.GETALL);
                list = (List<Hotel>)hotels;
            }
            return list;
        }

        public bool Update(Hotel hotel)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Execute(Hotel.UPDATE, new { @Id = hotel.Id, @Name = hotel.Name, @IdAdress = hotel.Address.Id, @Dt_Register = hotel.Dt_Register, @Price = hotel.Price });

                status = true;
            }
            return status;
        }


    }
}
