using Infraestrutura.Entities;

namespace Infraestrutura.Repository.Contract;

public interface IFornecedorRepository
{
    bool FornecedorCadastrado(string cnpj);

    Task<Fornecedor> LocalizarFornecedor(Fornecedor fornecedor);

    Task<Fornecedor> CadastrarFornecedor(Fornecedor fornecedor);

    Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor);

    Task<Fornecedor> InativarFornecedor(string cnpj);
}