namespace CadastrosBasicos.Models;

public class Cliente
{
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

    public string CPF { get; set; }

    public string Nome { get; set; }

    public DateOnly DataNascimento { get; set; }

    public char Sexo { get; set; }

    public DateOnly UltimaCompra { get; set; }

    public DateOnly DataCadastro { get; set; }

    public char Situacao { get; set; }

    public string ImprimirDadosCliente()
    {
        return $"CPF: {CPF} \n" +
            $"Nome: {Nome} \n" +
            $"Data de Nascimento: {DataNascimento:dd/MM/yyyy} \n" +
            $"Sexo: {Sexo} \n" +
            $"Última Compra: {UltimaCompra:dd/MM/yyy} \n" +
            $"Data de Cadastro: {DataCadastro:dd/MM/yyyy} \n" +
            $"Situação: {Situacao} \n";
    }
}