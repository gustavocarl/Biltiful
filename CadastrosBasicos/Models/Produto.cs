namespace CadastrosBasicos.Models;

public class Produto
{
    public Produto(string codigoBarras, string nome, float valorVenda, DateOnly ultimaVenda, char situacao)
    {
        CodigoBarras = codigoBarras;
        Nome = nome;
        ValorVenda = valorVenda;
        UltimaVenda = ultimaVenda;
        Situacao = situacao;
    }

    public string CodigoBarras { get; set; }

    public string Nome { get; set; }

    public float ValorVenda { get; set; }

    public DateOnly UltimaVenda { get; set; }

    public char Situacao { get; set; }

    public string ImprimirVenda()
    {
        return $"Código de barras: {CodigoBarras}\n" +
        $"Nome: {Nome}\n" +
        $"Valor de venda: R${ValorVenda.ToString().Replace(".", ",")}\n" +
        $"Data da última Venda: {UltimaVenda.ToString("dd/MM/yyyy")}\n" +
        $"Situação: {Situacao} \n";
    }
}