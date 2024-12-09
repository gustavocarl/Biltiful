namespace CadastrosBasicos.Services.Validacoes;

public class ValidacoesProduto
{
    public static bool IsValidEAN13(string eanCode)
    {
        if (eanCode.Length != 13 || !eanCode.All(char.IsDigit))
        {
            return false;
        }

        int[] digits = eanCode.Take(12).Select(c => int.Parse(c.ToString())).ToArray();

        int sumOdd = digits.Where((_, index) => index % 2 == 0).Sum();
        int sumEven = digits.Where((_, index) => index % 2 != 0).Sum() * 3;
        int totalSum = sumOdd + sumEven;

        int checksum = (10 - (totalSum % 10)) % 10;

        return checksum == int.Parse(eanCode[12].ToString());
    }

    public static bool ValidarNomeProduto(string nomeProduto)
    {
        if (string.IsNullOrEmpty(nomeProduto) || nomeProduto.Length < 3)
        {
            return false;
        }
        return true;
    }

    public static bool ValidarValorDoProduto(decimal valorProduto)
    {
        if (valorProduto < 0 || valorProduto > 1000)
        {
            return false;
        }
        return true;
    }
}