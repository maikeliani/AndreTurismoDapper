using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Hotel
    {
        public readonly static string INSERT = " insert into Hotel (Name, IdAdress, Dt_Register, Price ) " +
            "values ( @Name, @IdAdress, @Dt_Register, @Price)";
        public readonly static string GETALL = " select Id, Name, IdAdress, Dt_Register, Price from Hotel";

        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public DateTime Dt_Register { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);

        }
    }
}
