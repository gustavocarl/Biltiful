using Infraestrutura.Config;
using Infraestrutura.Entities;
using Infraestrutura.Repository.Contract;

namespace Infraestrutura.Repository.Implementation;

public class ProdutoRepository : IProdutoRepository
{
    private readonly DatabaseContext _databaseContext;

    public ProdutoRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public bool ProdutoCadastrado(string codigoBarras)
    {
        var produtoExistente = _databaseContext.Produto.FindAsync(codigoBarras).Result;

        if (produtoExistente == null)
        {
            return false;
        }

        return true;
    }

    public Task<Produto> LocalizarProduto(string codigoBarras)
    {
        throw new NotImplementedException();
    }

    public async Task<Produto> CadastrarProduto(Produto produto)
    {
        try
        {
            _databaseContext.Produto.Add(produto);
            await _databaseContext.SaveChangesAsync();

            return produto;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar produto {ex.Message}");
            throw;
        }
    }

    public Task<Produto> AtualizarProduto(Produto produto)
    {
        throw new NotImplementedException();
    }

    public Task<Produto> InativarProduto(Produto produto)
    {
        throw new NotImplementedException();
    }
}