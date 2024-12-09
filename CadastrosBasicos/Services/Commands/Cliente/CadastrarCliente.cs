using CadastrosBasicos.Services.Validacoes;
using CpfCnpjLibrary;
using Infraestrutura.Config;
using Infraestrutura.Repository.Contract;
using Infraestrutura.Repository.Implementation;
using System.Globalization;

namespace CadastrosBasicos.Services.Commands.Cliente;

public class CadastrarCliente
{
    private readonly IClienteRepository _clienteRepository;

    public CadastrarCliente()
    {
        _clienteRepository = new ClienteRepository(new DatabaseContext());
    }

    public void CadastrarNovoCliente()
    {
        string nome, cpf, dataNascimento;
        char sexo;

        do
        {
            Console.WriteLine("Informe o CPF do Cliente");
            cpf = Console.ReadLine()!;
        } while (!Cpf.Validar(cpf) || _clienteRepository.ClienteCadastrado(cpf));

        do
        {
            Console.WriteLine("Informe o Nome do Cliente");
            nome = Console.ReadLine()!;
        } while (!ValidacoesCliente.ValidaroNomeCliente(nome));

        do
        {
            Console.WriteLine("Informe a Data de Nascimento do Cliente: dd/mm/yyyy");
            dataNascimento = Console.ReadLine()!;
        } while (!ValidacoesCliente.ValidarDataNascimento(dataNascimento));

        DateOnly dataConvertidaCliente = DateOnly.ParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        do
        {
            Console.WriteLine("Informe o Sexo do Cliente: \nM - Masculino \nF - Feminino");
            sexo = char.Parse(Console.ReadLine()!);
        } while (!ValidacoesCliente.ValidarSexo(sexo));

        DateOnly ultimaCompra = DateOnly.FromDateTime(DateTime.Now);

        DateOnly dataCadastro = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';

        var cliente = new Infraestrutura.Entities.Cliente(cpf, nome, dataConvertidaCliente, sexo, ultimaCompra, dataCadastro, situacao);

        _clienteRepository.CadastrarCliente(cliente);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}