using CadastrosBasicos.Services.Validacoes;
using CpfCnpjLibrary;
using System.Globalization;

namespace CadastrosBasicos.Services.Commands.Fornecedor
{
    public class CadastrarFornecedor
    {
        public void CadastrarNovoFonecedor()
        {
            string cnpj, razaoSocial, dataAbertura;

            do
            {
                Console.WriteLine("Informe o CNPJ do Fornecedor");
                cnpj = Console.ReadLine()!;
            } while (!Cnpj.Validar(cnpj));

            do
            {
                Console.WriteLine("Informe a Razão Social do Fornecedor");
                razaoSocial = Console.ReadLine()!;
            } while (!ValidacoesFornecedor.ValidaroNomeFornecedor(razaoSocial));

            do
            {
                Console.WriteLine("Informe a Data de Abertura do Fornecedor: dd/mm/yyyy");
                dataAbertura = Console.ReadLine()!;
            } while (!ValidacoesFornecedor.ValidarDataAbertura(dataAbertura));

            DateOnly dataConvertidaAbertura = DateOnly.ParseExact(dataAbertura, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DateOnly ultimaCompra = DateOnly.FromDateTime(DateTime.Now.Date);

            DateOnly dataCadastro = DateOnly.FromDateTime(DateTime.Now.Date);

            char situacao = 'A';

            var fornecedor = new Models.Fornecedor(cnpj, razaoSocial, dataConvertidaAbertura, ultimaCompra, dataCadastro, situacao);

            Console.WriteLine(fornecedor.ImprimirDadosFornecedor());

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}