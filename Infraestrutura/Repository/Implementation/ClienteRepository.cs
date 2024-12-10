using Infraestrutura.Config;
using Infraestrutura.Entities;
using Infraestrutura.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Repository.Implementation;

public class ClienteRepository : IClienteRepository
{
    private readonly DatabaseContext _databaseContext;

    public ClienteRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public bool ClienteCadastrado(string cpf)
    {
        var clienteExistente = _databaseContext.Cliente.FirstOrDefault(c => c.CPF == cpf);

        if (clienteExistente == null)
        {
            return false;
        }
        return true;
    }

    public async Task<Cliente> LocalizarCliente(string cpf)
    {
        var clienteExistente = await _databaseContext.Cliente.Where(c => c.CPF == cpf).FirstOrDefaultAsync();

        if (clienteExistente is null)
        {
            throw new Exception("Cliente não encontrado");
        }
        return clienteExistente;
    }

    public async Task MostrarCliente(string cpf)
    {
        try
        {
            var cliente = await LocalizarCliente(cpf);

            Console.WriteLine("Detalhes do Cliente:");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            Console.WriteLine($"Sexo: {cliente.Sexo}");
            Console.WriteLine($"Situação: {cliente.Situacao}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    public async Task<Cliente> CadastrarCliente(Cliente cliente)
    {
        try
        {
            _databaseContext.Cliente.Add(cliente);
            await _databaseContext.SaveChangesAsync();
            return cliente;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar cliente: {ex.Message}");
            throw;
        }
    }

    public async Task<Cliente> AtualizarCliente(Cliente cliente)
    {
        var clienteExistente = _databaseContext.Cliente
            .Where(c => c.CPF == cliente.CPF).FirstOrDefault() ?? throw new Exception("Cliente não encontrado");

        clienteExistente.Nome = cliente.Nome;
        clienteExistente.DataNascimento = cliente.DataNascimento;
        clienteExistente.Sexo = cliente.Sexo;

        await _databaseContext.SaveChangesAsync();
        return cliente;
    }

    public async Task<Cliente> InativarCliente(string cpf)
    {
        var clienteExistente = await _databaseContext.Cliente.FindAsync(cpf) ?? throw new KeyNotFoundException("Cliente não encontrado");

        if (clienteExistente.Situacao == 'A')
        {
            clienteExistente.Situacao = 'I';
        }
        else
        {
            clienteExistente.Situacao = 'A';
        }
        _databaseContext.Cliente.Update(clienteExistente);
        await _databaseContext.SaveChangesAsync();

        return clienteExistente;
    }
}