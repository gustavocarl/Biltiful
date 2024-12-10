using CpfCnpjLibrary;
using Infraestrutura.Config;
using Infraestrutura.Repository.Contract;
using Infraestrutura.Repository.Implementation;

namespace CadastrosBasicos.Services.Queries.Cliente;

public class BuscarCliente
{
    private readonly IClienteRepository _clienteRepository;

    public BuscarCliente()
    {
        _clienteRepository = new ClienteRepository(new DatabaseContext());
    }

    public void LocalizarCliente()
    {
        string cpf;

        do
        {
            Console.WriteLine("Informe o CPF do Cliente");
            cpf = Console.ReadLine()!;
        } while (!Cpf.Validar(cpf) || !_clienteRepository.ClienteCadastrado(cpf));

        _clienteRepository.MostrarCliente(cpf);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}