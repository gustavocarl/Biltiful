using CadastrosBasicos.Services.Validacoes;
using Infraestrutura.Config;
using Infraestrutura.Repository.Contract;
using Infraestrutura.Repository.Implementation;

namespace CadastrosBasicos.Services.Commands.Produto;

public class CadastrarProduto
{
    private readonly IProdutoRepository _produtoRepository;

    public CadastrarProduto()
    {
        _produtoRepository = new ProdutoRepository(new DatabaseContext());
    }


    public void CadastrarNovoProduto()
    {
        string codigoBarras, nome;
        decimal valorVenda;

        do
        {
            Console.WriteLine("Informe o Código de Barras do Produto: ");
            codigoBarras = Console.ReadLine()!;
        } while (!ValidacoesProduto.IsValidEAN13(codigoBarras) || _produtoRepository.ProdutoCadastrado(codigoBarras));

        do
        {
            Console.WriteLine("Informe o Nome do Produto");
            nome = Console.ReadLine()!;
        } while (!ValidacoesProduto.ValidarNomeProduto(nome));

        do
        {
            Console.WriteLine("Informe o Valor da Venda");
            valorVenda = decimal.Parse(Console.ReadLine()!);
        } while (!ValidacoesProduto.ValidarValorDoProduto(valorVenda));

        DateOnly ultimaVenda = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';

        var produto = new Infraestrutura.Entities.Produto(codigoBarras, nome, valorVenda, ultimaVenda, situacao);

        _produtoRepository.CadastrarProduto(produto);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}