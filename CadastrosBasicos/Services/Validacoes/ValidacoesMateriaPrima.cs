namespace CadastrosBasicos.Services.Validacoes
{
    public class ValidacoesMateriaPrima
    {
        public static bool ValidarNomeMateriaPrima(string materiaPrima)
        {
            if (string.IsNullOrEmpty(materiaPrima) || materiaPrima.Length < 3)
            {
                return false;
            }
            return true;
        }
    }
}