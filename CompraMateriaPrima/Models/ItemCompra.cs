namespace CompraMateriaPrima.Models
{
    public class ItemCompra
    {
        public int Id { get; set; }

        public string MateriaPrima { get; set; }

        public float Quantidade { get; set; }

        public float ValorUnitario { get; set; }

        public float TotalItem { get; set; }
    }
}