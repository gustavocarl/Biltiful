using System.ComponentModel.DataAnnotations;

namespace Infraestrutura.Entities;

public class Fornecedor
{
    public Fornecedor()
    {
    }

    public Fornecedor(string cNPJ, string razaoSocial, DateOnly dataAbertura, DateOnly ultimaCompra, DateOnly dataCadastro, char situacao)
    {
        CNPJ = cNPJ;
        RazaoSocial = razaoSocial;
        DataAbertura = dataAbertura;
        UltimaCompra = ultimaCompra;
        DataCadastro = dataCadastro;
        Situacao = situacao;
    }

    [Key]
    public string CNPJ { get; set; }

    [Required]
    public string RazaoSocial { get; set; }

    [Required]
    public DateOnly DataAbertura { get; set; }

    [Required]
    public DateOnly UltimaCompra { get; set; }

    [Required]
    public DateOnly DataCadastro { get; set; }

    [Required]
    public char Situacao { get; set; }
}