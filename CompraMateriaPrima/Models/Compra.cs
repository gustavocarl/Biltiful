namespace CompraMateriaPrima.Models
{
    public class Compra
    {
        public int Id { get; set; }

        public DateTime DataCompra { get; set; }

        public string Fornecedor { get; set; }

        public float ValorTotal { get; set; }
    }
}