using System.Net.WebSockets;
using System.Threading.Channels;
using Controllers;
using Microsoft.VisualBasic.FileIO;
using Models;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Projeto Agência de turismo com Dapper!");

        var data = new City()
        {
            Description = "Américo Brasiliense",
            Dt_Register = DateTime.Now
        };

        var address = new Address
        {
            Street = "Rua Nelson Nogueira",
            Number = 103,
            NeighborHood = " vale do sol",
            ZipCode = "14804087",
            Complement = "",
            City = new City
            {

                Description = "Araraquara",
                Dt_Register = DateTime.Now
            },
            Dt_Register = DateTime.Now

        };


        var address2 = new Address
        {
            Street = "Rua 13 de maio",
            Number = 1,
            NeighborHood = "vila xavier",
            ZipCode = "14800520",
            Complement = "",
            City = new City
            {

                Description = "Araraquara",
                Dt_Register = DateTime.Now
            },
            Dt_Register = DateTime.Now

        };


        var address4 = new Address //APENAS PARA UPDATE, PASSANDO PARAMETRO ID COM VALOR
        {
            Id = 126,
            Street = "9 de julho",
            Number = 15,
            NeighborHood = "vila xavier",
            ZipCode = "14800300",
            Complement = "",
            City = new City
            {

                Description = "Araraquara",
                Dt_Register = DateTime.Now
            },
            Dt_Register = DateTime.Now

        };

        var address5 = new Address //APENAS PARA UPDATE, PASSANDO PARAMETRO ID COM VALOR
        {
            
            Street = "29 de julho",
            Number = 165,
            NeighborHood = "vila xavier",
            ZipCode = "14800300",
            Complement = "",
            City = new City
            {

                Description = "Londrina",
                Dt_Register = DateTime.Now
            },
            Dt_Register = DateTime.Now

        };


        var client = new Client()
        {
            Name = "Nicolau",
            Telephone = "193",
            Address = address,
            Dt_Register = DateTime.Now,

        };

        var client4 = new Client()
        {
            Name = "Célia",
            Telephone = "996123380",
            Address = address4,
            Dt_Register = DateTime.Now,

        };

        var client3 = new Client()
        {
            Name = "Maikel",
            Telephone = "997225955",
            Address = address2,
            Dt_Register = DateTime.Now,

        };

        var client2 = new Client()
        {
            Name = "Arnaldo",
            Telephone = "284756655",
            Address = address2,
            Dt_Register = DateTime.Now,

        };

        var hotel = new Hotel()
        {
            Name = " Trivado",
            Address = address,
            Dt_Register = DateTime.Now,
            Price = 123
        };

        var hotel2 = new Hotel()
        {
            Name = " London",
            Address = address2,
            Dt_Register = DateTime.Now,
            Price = 143
        };

        var hotel3 = new Hotel()
        {
            Id = 4,
            Name = " London",
            Address = address4,
            Dt_Register = DateTime.Now,
            Price = 143
        };

        var ticket = new Ticket()
        {
            SourceAddress = address2,
            DestinationAddress = address,
            Client = client2,
            Dt_Register = DateTime.Now,
            Price = 72
        };

        var ticket5 = new Ticket() // teste update
        {
            Id=26,
            SourceAddress = address4,

            DestinationAddress = address4,

            Dt_Register = DateTime.Now,
        
                Client = client,
               
                 Price = 669
        };

    var package = new Package()
    {
        Hotel = hotel,
        Ticket = ticket,
        Dt_Register = DateTime.Now,
        Price = 170,
        Client = client
    };

    var package2 = new Package()
    {
        Hotel = hotel2,
        Ticket = ticket5,
        Dt_Register = DateTime.Now,
        Price = 245,
        Client = client
    };

    var client5 = new Client() // para tester Update
    {
        Id = 44,
        Name = "Celinha",
        Telephone = "996123380",
        Address = new()
        {
            Id = 110,
            Street = "avenida 7",
            Number = 145,
            NeighborHood = "centro",
            ZipCode = "14800300",
            Complement = "",
            City = new City
            {
                Id = 2,
                Description = "Araraquara",
                Dt_Register = DateTime.Now
            },
            Dt_Register = DateTime.Now
        },
        Dt_Register = DateTime.Now,

    };


        //delete ticket

        var deletedTicket = new TicketController().Delete(26) ? " deletado" : "erro";
        Console.WriteLine(deletedTicket);

        //update Ticket
        var updatedTicket = new TicketController().UpDate(ticket5) ? " alterado" : "erro";
        Console.WriteLine(updatedTicket);
    //inserindo ticket

  //  var insertedTicket = new TicketController().Insert(ticket5);
    //Console.WriteLine("ticket inserido id: " + insertedTicket);
       

        //deletando hotel
        //var deleted = new HotelController().Delete(16) ? " deletado" : "erro";
       // Console.WriteLine(deleted);


        //update hotel

       // var upHotel = new HotelController().Update(hotel3) ? " hotel alterado" : "erro ao alterar";
       // Console.WriteLine(upHotel);

        // update address
        //  var updatedAddress = (new AddressController().UpDate(address4));
        // Console.WriteLine(updatedAddress);



        
        //inserindo endereco   // inseriu no id 126

       // int idAddressInserted = new AddressController().Insert(address5);
       // Console.WriteLine($"Inserido no id: {idAddressInserted}"); 
        

        //inserindo client

        //int insertedClient = new ClientController().Insert(client4);
        // Console.WriteLine("Cliente inserido no id: "+ insertedClient);

        // Client GetAll()
        // new ClientController().GetAll().ForEach(x => Console.WriteLine(x));


        //update Client
        //var updatedClient = new ClientController().Update(client5) ? "cliente atualizado" : "erro ao atualizar cliente";

        //deletando client

       // var deleted =new ClientController().Delete(1) ? " deletado" : " erro ao deletar";
       // Console.WriteLine(deleted);


    }
}