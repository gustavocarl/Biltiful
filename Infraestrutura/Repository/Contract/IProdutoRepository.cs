using Infraestrutura.Entities;

namespace Infraestrutura.Repository.Contract;

public interface IProdutoRepository
{

    bool ProdutoCadastrado(string codigoBarras);

    Task<Produto> LocalizarProduto(string codigoBarras);

    Task<Produto> CadastrarProduto(Produto produto);

    Task<Produto> AtualizarProduto(Produto produto);

    Task<Produto> InativarProduto(Produto produto);
}