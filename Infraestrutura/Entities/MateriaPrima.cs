using System.ComponentModel.DataAnnotations;

namespace Infraestrutura.Entities;

public class MateriaPrima
{
    public MateriaPrima()
    {
    }

    public MateriaPrima(Guid id, string nome, DateOnly ultimaCompra, DateOnly dataCadastro, char situacao)
    {
        Id = id;
        Nome = nome;
        UltimaCompra = ultimaCompra;
        DataCadastro = dataCadastro;
        Situacao = situacao;
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public DateOnly UltimaCompra { get; set; }
    
    [Required]
    public DateOnly DataCadastro { get; set; }

    [Required]
    public char Situacao { get; set; }
}