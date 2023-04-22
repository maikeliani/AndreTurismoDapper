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
            Street = "Rua sem nome",
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
            Name = "Elias",
            Telephone = "190",
            Address = address,
            Dt_Register = DateTime.Now,

        };








        //INSERINDO CLIENTE
       string informationClient = (new ClientController().Insert(client) ? "cliente inserido" : " erro ao inserir cliente");


        //inserindo endereco
        
       //// string returnAddress = (new AddressController().Insert(address2) ? "Endereço cadastrado" : " erro ao cadastrar endereço");
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

       // new CityController().GetAll().ForEach(x => Console.WriteLine(x));

    }
}