using System.Text.RegularExpressions;

namespace CadastrosBasicos.Services.Validacoes
{
    public class ValidacoesCliente
    {
        public static bool ValidaroNomeCliente(string nome)
        {
            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
            {
                return false;
            }

            return true;
        }

        public static bool ValidarDataNascimento(string dataNascimento)
        {
            string validarDataRegex = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}";

            if (!Regex.IsMatch(dataNascimento, validarDataRegex))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarSexo(char sexo)
        {
            char[] sexosValidos = { 'M', 'F' };

            for (var i = 0; i < sexosValidos.Length; i++)
            {
                if (sexo == sexosValidos[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}