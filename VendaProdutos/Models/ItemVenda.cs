namespace VendaProdutos.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }

        public string Produto { get; set; }

        public int Quantidade { get; set; }

        public float ValorUnitario { get; set; }

        public float TotalItem { get; set; }
    }
}