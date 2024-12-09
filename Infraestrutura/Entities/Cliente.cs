using System.ComponentModel.DataAnnotations;

namespace Infraestrutura.Entities;

public class Cliente
{
    public Cliente()
    { }

    public Cliente(string cpf, string nome, DateOnly dataNascimento, char sexo, DateOnly ultimaCompra, DateOnly dataCadastro, char situacao)
    {
        CPF = cpf;
        Nome = nome;
        DataNascimento = dataNascimento;
        Sexo = sexo;
        UltimaCompra = ultimaCompra;
        DataCadastro = dataCadastro;
        Situacao = situacao;
    }

    [Key]
    public string CPF { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public DateOnly DataNascimento { get; set; }

    [Required]
    public char Sexo { get; set; }

    [Required]
    public DateOnly UltimaCompra { get; set; }

    [Required]
    public DateOnly DataCadastro { get; set; }

    [Required]
    public char Situacao { get; set; }
}