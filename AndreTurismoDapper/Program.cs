using Controllers;
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


        var client = new Client()
        {
            Name = "Nicolau",
            Telephone = "193",
            Address = address,
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

        var ticket = new Ticket()
        {
            SourceAddress = address2,
            DestinationAddress = address,
            Client = client2,
            Dt_Register = DateTime.Now,
            Price = 72
        };

        var ticket2 = new Ticket()
        {
            SourceAddress = address,
            DestinationAddress = address2,
            Client = client,
            Dt_Register = DateTime.Now,
            Price = 99
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
            Ticket = ticket2,
            Dt_Register = DateTime.Now,
            Price = 245,
            Client = client
        };





        //--------------------------------    UPDATES    ---------------------------------

        /*
        // update adress
        var updatedAddress = (new AddressController().UpDate(" rua das andorinhas", 44, "vila da paz", "14100-333", " ", 4) ? " endereço atualizado" : " erro ao atualizar endereço");
        Console.WriteLine(updatedAddress);

        //update city
        var updatedCity = (new CityController().Update("Catanduva", 4) ? " cidade atualizada" : "erro ao atualizar cidade");
        Console.WriteLine(updatedCity);

        // update hotel
        var updatedHotel = (new HotelController().Update("recanto do sossego", address2, 140, 3) ? " hotel atualizado" : " erro ao atualizar hotel");
        Console.WriteLine(updatedHotel);

        //update ticket!!
        var ticketUpdated = (new TicketController().UpDate(address, address2, client, 56, 4) ? " ticker alterado" : " erro ao alterar ticket");
        Console.WriteLine(ticketUpdated);

        //update Package
        var packageUpdated = (new PackageController().Update(15, 15, 200, 39, 2) ? " package atualizado com sucesso" : "erro ao atualizar package");
        Console.WriteLine(packageUpdated);
        */





        //----------------------------    DELETES      -----------------------------------

        /*
        //deletando package
        var deletedPackage = (new PackageController().Delete(0) ? " package deletado" : "erro ao deletar package");
        Console.WriteLine(deletedPackage);

        //deletanto hotel
         var DeleteHotel = (new HotelController().Delete(1) ? " Hotel deletado" : "erro ao deletar hotel");
        Console.WriteLine(DeleteHotel);

        //deletanto ticket
        var deletedTicket = (new TicketController().Delete(13) ? " ticket deletado" : "erro ao deletar ticket");
         Console.WriteLine(deletedTicket);

        //deletando client
         var deletedClient = (new ClientController().Delete(2) ? " cliente deletado" : "erro ao deletar cliente");
         Console.WriteLine(deletedClient);

        //deletando Address
        var deletedAddress = (new AddressController().Delete(0) ? " endereço deletado" : "erro ao deletar endereço");
        Console.WriteLine(deletedAddress);

        //deletando City
          var deletedCity = (new CityController().Delete(3) ? " cidade deletada" : "erro ao deletar cidade");
          Console.WriteLine(deletedCity);
        */



        /* --------------------------------   INSERTS   --------------------------------
        //INSERINDO CIDADE
        string returnInformation = (new CityController().Insert(data) ? "Cidade inserida" : "Erro ao inserir cidade");
        Console.WriteLine(returnInformation);


        //inserindo endereco

        string returnAddress = (new AddressController().Insert(address2) ? "Endereço cadastrado" : " erro ao cadastrar endereço");
        Console.WriteLine(returnAddress);

        //INSERINDO CLIENTE
        string informationClient = (new ClientController().Insert(client) ? "cliente inserido" : " erro ao inserir cliente");
        Console.WriteLine(informationClient);

        //inserindo hotel

        string informationHotel = (new HotelController().Insert(hotel) ? "Hotel inserido" : " erro ao inserir hotel");
        Console.WriteLine(informationHotel);


        //inserindo ticket

        string returnInformationTicket = (new TicketController().Insert(ticket) ? " Ticket adicionado" : " erro ao adicionar ticket");
        Console.WriteLine(returnInformationTicket);


        // inserindo package

        var returnInformationPackage = (new PackageController().Insert(package2) ? " package inserido com sucesso" : " erro ao cadastrar package");
        Console.WriteLine(returnInformationPackage);
        */



        //--------------------    GET ALL    -----------------------------------

        /*
        new PackageController().GetAll().ForEach(x => Console.WriteLine(x));
        new HotelController().GetAll().ForEach(x => Console.WriteLine(x));

        new AddressController().GetAll().ForEach(x => Console.WriteLine(x));
        new TicketController().GetAll().ForEach(x => Console.WriteLine(x));


        new ClientController().GetAll().ForEach(x => Console.WriteLine(x));

        new CityController().GetAll().ForEach(x => Console.WriteLine(x));
        */


    }
}