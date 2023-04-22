using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
    {
        public readonly static string INSERT = " insert into Ticket (SourceAdress, DestinationAdress, IdClient, Dt_Register, Price) " +
            "values ( @SourceAdress, @DestinationAdress, @IdClient, @Dt_Register, @Price )";
        public readonly static string GETALL = " select SourceAdress, DestinationAdress, IdClient, Dt_Register, Price from Ticket";

        public int Id { get; set; }

        public Address SourceAddress { get; set; }

        public Address DestinationAddress { get; set; }

        public Client Client { get; set; }

        public DateTime Dt_Register { get; set; }

        public double Price { get; set; }
    }
}
