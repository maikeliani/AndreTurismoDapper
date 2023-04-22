using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City
    {
        public readonly static string INSERT = " insert into City (Description, Dt_Register) values ( @Description, @Dt_Register)";
        public readonly static string GETALL = " select Description, Dt_Register from City";

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Dt_Register { get; set; }
    }
}
