using Infraestrutura.Entities;

namespace Infraestrutura.Repository.Contract;

public interface IClienteRepository
{
    bool ClienteCadastrado(string cpf);

    Task<Cliente> LocalizarCliente(Cliente cliente);

    Task<Cliente> CadastrarCliente(Cliente cliente);

    Task<Cliente> AtualizarCliente(Cliente cliente);

    Task<Cliente> InativarCliente(Cliente cliente);
}