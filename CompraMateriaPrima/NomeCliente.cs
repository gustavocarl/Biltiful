namespace CompraMateriaPrima
{
    public class NomeCliente
    {
        public bool ValidarTamanhoNomeCliente(string nome)
        {
            if (nome.Length < 3)
            {
                return false;
            }
            return true;
        }
    }
}