namespace CadastrosBasicos.Models;

public class Fornecedor
{
    public Fornecedor(string cnpj, string razaoSocial, DateOnly dataAbertura, DateOnly ultimaCompra, DateOnly dataCadastro, char situacao)
    {
        CNPJ = cnpj;
        RazaoSocial = razaoSocial;
        DataAbertura = dataAbertura;
        UltimaCompra = ultimaCompra;
        DataCadastro = dataCadastro;
        Situacao = situacao;
    }

    public string CNPJ { get; set; }

    public string RazaoSocial { get; set; }

    public DateOnly DataAbertura { get; set; }

    public DateOnly UltimaCompra { get; set; }

    public DateOnly DataCadastro { get; set; }

    public char Situacao { get; set; }

    public string ImprimirDadosFornecedor()
    {
        return $"CNPJ: {CNPJ} \n" +
            $"Razão Social: {RazaoSocial} \n" +
            $"Data de Abertura: {DataAbertura:dd/MM/yyyy} \n" +
            $"Última Compra: {UltimaCompra:dd/MM/yyyy} \n" +
            $"Data do Cadastro: {DataCadastro:dd/MM/yyyy} \n" +
            $"Situação: {Situacao} \n";
    }
}