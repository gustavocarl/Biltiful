using Infraestrutura.Config;
using Infraestrutura.Entities;
using Infraestrutura.Repository.Contract;

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
        var clienteExistente = _databaseContext.Cliente.FindAsync(cpf).Result;

        if (clienteExistente == null)
        {
            return false;
        }
        return true;
    }

    public async Task<Cliente> LocalizarCliente(Cliente cliente)
    {
        throw new NotImplementedException();
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

    public Task<Cliente> AtualizarCliente(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public Task<Cliente> InativarCliente(Cliente cliente)
    {
        throw new NotImplementedException();
    }
}