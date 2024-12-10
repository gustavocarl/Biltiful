using Infraestrutura.Entities;

namespace Infraestrutura.Repository.Contract;

public interface IClienteRepository
{
    bool ClienteCadastrado(string cpf);

    Task<Cliente> LocalizarCliente(string cpf);

    Task MostrarCliente(string cpf);

    Task<Cliente> CadastrarCliente(Cliente cliente);

    Task<Cliente> AtualizarCliente(Cliente cliente);

    Task<Cliente> InativarCliente(string cpf);
}