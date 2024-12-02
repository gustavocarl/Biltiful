using CadastrosBasicos.Services.Commands.Fornecedor;

namespace UI.Menus.Cadastros;

public class MenuFornecedor
{
    public void ShowMenuFornecedor()
    {
        var cadastroBasicoMenu = new CadastrosBasicosMenu();
        var fornecedorService = new CadastrarFornecedor();

        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("Menu de Gestão de Fornecedor");
        Console.WriteLine("=============================");
        Console.WriteLine("1 - Cadastrar Novo Fornecedor");
        Console.WriteLine("2 - Localizar Fornecedor");
        Console.WriteLine("3 - Editar Fornecedor");
        Console.WriteLine("4 - Inativar Fornecedor");
        Console.WriteLine("=============================");
        Console.WriteLine("0 - Voltar ao Menu anterior");
        Console.WriteLine("=============================");

        switch (Console.ReadLine()!)
        {
            case "0":
                cadastroBasicoMenu.ShowMenuCadastroBasico();
                break;

            case "1":
                fornecedorService.CadastrarNovoFonecedor();
                ShowMenuFornecedor();
                break;

            default:
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                ShowMenuFornecedor();
                break;
        }
    }
}