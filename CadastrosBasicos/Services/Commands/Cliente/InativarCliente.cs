using CpfCnpjLibrary;
using Infraestrutura.Config;
using Infraestrutura.Repository.Contract;
using Infraestrutura.Repository.Implementation;

namespace CadastrosBasicos.Services.Commands.Cliente;

public class InativarCliente
{
    private readonly IClienteRepository _clienteRepository;

    public InativarCliente()
    {
        _clienteRepository = new ClienteRepository(new DatabaseContext());
    }

    public void InativarClienteCadastrado()
    {
        string cpf;

        do
        {
            Console.WriteLine("Informe o CPF do Cliente");
            cpf = Console.ReadLine()!;
        } while (!Cpf.Validar(cpf) || !_clienteRepository.ClienteCadastrado(cpf));


        _clienteRepository.InativarCliente(cpf);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}