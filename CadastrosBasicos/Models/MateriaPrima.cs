namespace CadastrosBasicos.Models
{
    public class MateriaPrima
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public DateTime UltimaCompra { get; set; }

        public DateTime DataCadastro { get; set; }

        public char Situacao { get; set; }
    }
}