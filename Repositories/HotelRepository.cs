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
                db.Execute(Hotel.INSERT, hotel);
                status = true;
            }
            return status;
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
