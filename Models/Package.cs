using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Package
    {
        public readonly static string INSERT = " insert into Package (IdHotel, IdTicket, Dt_Register, Price, IdClient) values ( @IdHotel, @IdTicket, @Dt_Register, @Price, @IdClient)";
        public readonly static string GETALL = " select Id, IdHotel, IdTicket, Dt_Register, Price, IdClient from Ticket";
        public int Id { get; set; }
        public Hotel Hotel { get; set; }

        public Ticket Ticket { get; set; }

        public DateTime Dt_Register { get; set; }

        public double Price { get; set; }

        public Client Client { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);

        }
    }
}
