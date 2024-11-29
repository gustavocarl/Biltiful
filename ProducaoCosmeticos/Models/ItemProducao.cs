namespace ProducaoCosmeticos.Models
{
    public class ItemProducao
    {
        public int Id { get; set; }

        public DateTime DataProducao { get; set; }

        public string MateriaPrima { get; set; }

        public float QuantidadeMateriaPrima { get; set; }
    }
}