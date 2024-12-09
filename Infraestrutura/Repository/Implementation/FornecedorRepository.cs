using Infraestrutura.Config;
using Infraestrutura.Entities;
using Infraestrutura.Repository.Contract;

namespace Infraestrutura.Repository.Implementation;

public class FornecedorRepository : IFornecedorRepository
{
    private readonly DatabaseContext _databaseContext;

    public FornecedorRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public bool FornecedorCadastrado(string cnpj)
    {
        var fornecedor = _databaseContext.Fornecedor.FindAsync(cnpj).Result;

        if (fornecedor == null)
            return false;

        return true;
    }

    public Task<Fornecedor> LocalizarFornecedor(Fornecedor fornecedor)
    {
        throw new NotImplementedException();
    }

    public async Task<Fornecedor> CadastrarFornecedor(Fornecedor fornecedor)
    {
        try
        {
            _databaseContext.Fornecedor.Add(fornecedor);
            await _databaseContext.SaveChangesAsync();
            return fornecedor;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao Cadastrar Fornecedor: {ex.Message}");
            throw;
        }
    }

    public Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor)
    {
        throw new NotImplementedException();
    }

    public Task<Fornecedor> InativarFornecedor(string cnpj)
    {
        throw new NotImplementedException();
    }
}