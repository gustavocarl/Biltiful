using CadastrosBasicos.Services.Validacoes;

namespace CadastrosBasicos.Services.Commands.Produto;

public class CadastrarProduto
{
    public void CadastrarNovoProduto()
    {
        string codigoBarras, nome;
        float valorVenda;

        do
        {
            Console.WriteLine("Informe o Código de Barras do Produto: ");
            codigoBarras = Console.ReadLine()!;
        } while (!ValidacoesProduto.IsValidEAN13(codigoBarras));

        do
        {
            Console.WriteLine("Informe o Nome do Produto");
            nome = Console.ReadLine()!;
        } while (!ValidacoesProduto.ValidarNomeProduto(nome));

        do
        {
            Console.WriteLine("Informe o Valor da Venda");
            valorVenda = float.Parse(Console.ReadLine()!);
        } while (!ValidacoesProduto.ValidarValorDoProduto(valorVenda));

        DateOnly ultimaVenda = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';

        var produto = new Models.Produto(codigoBarras, nome, valorVenda, ultimaVenda, situacao);

        Console.WriteLine(produto.ImprimirVenda());
    }
}