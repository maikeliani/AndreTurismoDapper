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

        var hotel = new Hotel()
        {
            Name = " Trivado",
            Address = address,
            Dt_Register = DateTime.Now,
            Price = 123
        };

        var ticket = new Ticket()
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
            Dt_Register= DateTime.Now,
            Price = 120,
            Client = client
        };





        //deletando City
        var deletedCity = (new CityController().Delete(3) ? " cidade deletada" : "erro ao deletar cidade");
        Console.WriteLine(deletedCity);


        //deletando Address
        //var deletedAddress = (new AddressController().Delete(0) ? " endereço deletado" : "erro ao deletar endereço");
        //Console.WriteLine(deletedAddress);



        //deletando client
        // var deletedClient = (new ClientController().Delete(2) ? " cliente deletado" : "erro ao deletar cliente");
        //  Console.WriteLine(deletedClient);



        //deletanto ticket
        //var deletedTicket = (new TicketController().Delete(13) ? " ticket deletado" : "erro ao deletar ticket");
        // Console.WriteLine(deletedTicket);


        //deletando package

        //var deletedPackage = (new PackageController().Delete(0) ? " package deletado" : "erro ao deletar package");
        //Console.WriteLine(deletedPackage);


        //deletanto hotel

        // var DeleteHotel = (new HotelController().Delete(1) ? " Hotel deletado" : "erro ao deletar hotel");
        // Console.WriteLine(DeleteHotel);





        // inserindo package

        //var returnInformationPackage = (new PackageController().Insert(package) ? " package inserido com sucesso" : " erro ao cadastrar package");
        // Console.WriteLine(returnInformationPackage);




        //inserindo ticket

        // string returnInformationTicket = (new TicketController().Insert(ticket) ? " Ticket adicionado" : " erro ao adicionar ticket");
        // Console.WriteLine(returnInformationTicket);



        //inserindo hotel
        /*
        string informationHotel = (new HotelController().Insert(hotel) ? "Hotel inserido" : " erro ao inserir hotel");
        Console.WriteLine(informationHotel);
        */

        //INSERINDO CLIENTE
        //string informationClient = (new ClientController().Insert(client) ? "cliente inserido" : " erro ao inserir cliente");
        // Console.WriteLine(informationClient);


        //inserindo endereco

        // string returnAddress = (new AddressController().Insert(address2) ? "Endereço cadastrado" : " erro ao cadastrar endereço");
        // Console.WriteLine(returnAddress);


        /*
        //INSERINDO CIDADE
        string returnInformation = (new CityController().Insert(data) ? "Cidade inserida" : "Erro ao inserir cidade");
        Console.WriteLine(returnInformation);
        */




        //LISTA TODAS AS CIDADES INSERIDAS
        // new CityController().GetAll().ForEach(x => Console.WriteLine(x));
        // new AddressController().GetAll().ForEach(address => Console.WriteLine());
        // Console.ReadLine();

        // string returnCityAfterDelete = new CityController().Delete(2) ?" CIdade deletada ": " erro ao deletar cidade";



        //new CityController().GetAll().ForEach(x => Console.WriteLine(x));

        //new AddressController().GetAll().ForEach(x => Console.WriteLine(x));

    }
}