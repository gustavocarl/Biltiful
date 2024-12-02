namespace CadastrosBasicos.Models
{
    public class MateriaPrima
    {
        public MateriaPrima(Guid id, string nome, DateOnly ultimaCompra, DateOnly dataCadastro, char situacao)
        {
            Id = id;
            Nome = nome;
            UltimaCompra = ultimaCompra;
            DataCadastro = dataCadastro;
            Situacao = situacao;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateOnly UltimaCompra { get; set; }

        public DateOnly DataCadastro { get; set; }

        public char Situacao { get; set; }

        public string ImprimirMateriaPrima()
        {
            return $"Id: {Id}\n" +
            $"Nome: {Nome}\n" +
            $"Última Compra: {UltimaCompra:dd/MM/yyyy}\n" +
            $"Data Cadastro: {DataCadastro:dd/MM/yyyy}\n" +
            $"Situação: {Situacao}\n";
        }
    }
}