﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client
    {
        public readonly static string INSERT = " insert into Client (Name, Telephone, IdAdress, Dt_Register) values ( @Name, @Telephone, @IdAdress, @Dt_Register )";
        public readonly static string GETALL = " select Name, Telephone, IdAdress, Dt_Register from Client";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        public Address Address { get; set; }

        public DateTime Dt_Register { get; set; }

        public override string ToString()
        {
            return $"\nId: {Id}\nName: {Name}\nTelefone: {Telephone}" +
                $"\nEndereço: {Address}\nData de Registro: {Dt_Register}";
        }
    }
}