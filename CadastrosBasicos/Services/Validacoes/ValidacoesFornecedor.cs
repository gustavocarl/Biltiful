using System.Text.RegularExpressions;

namespace CadastrosBasicos.Services.Validacoes;

public class ValidacoesFornecedor
{
    public static bool ValidaroNomeFornecedor(string razaoSocial)
    {
        if (string.IsNullOrEmpty(razaoSocial) || razaoSocial.Length < 3)
        {
            return false;
        }

        return true;
    }

    public static bool ValidarDataAbertura(string dataAbertura)
    {
        string validarDataRegex = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}";

        if (!Regex.IsMatch(dataAbertura, validarDataRegex))
        {
            return false;
        }

        return true;
    }
}