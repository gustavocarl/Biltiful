using System.ComponentModel.DataAnnotations;

namespace Infraestrutura.Entities;

public class Produto
{
    public Produto()
    {
    }

    public Produto(string codigoBarras, string nome, decimal valorVenda, DateOnly ultimaVenda, char situacao)
    {
        CodigoBarras = codigoBarras;
        Nome = nome;
        ValorVenda = valorVenda;
        UltimaVenda = ultimaVenda;
        Situacao = situacao;
    }

    [Key]
    public string CodigoBarras { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public decimal ValorVenda { get; set; }

    [Required]
    public DateOnly UltimaVenda { get; set; }

    [Required]
    public char Situacao { get; set; }
}