using CadastrosBasicos.Services.Commands.Produto;

namespace UI.Menus.Cadastros;

public class MenuProduto
{
    public void ShowMenuProduto()
    {
        var cadastroBasicoMenu = new CadastrosBasicosMenu();
        var produtoService = new CadastrarProduto();

        Console.Clear();

        Console.WriteLine("===========================");
        Console.WriteLine("Menu Gestão de Produto");
        Console.WriteLine("===========================");
        Console.WriteLine("1 - Cadastrar Novo Produto");
        Console.WriteLine("2 - Localizar Produto");
        Console.WriteLine("3 - Editar Produto");
        Console.WriteLine("4 - Inativar Produto");
        Console.WriteLine("===========================");
        Console.WriteLine("0 - Voltar ao Menu anterior");
        Console.WriteLine("===========================");

        switch (Console.ReadLine())
        {
            case "0":
                cadastroBasicoMenu.ShowMenuCadastroBasico();
                break;

            case "1":
                produtoService.CadastrarNovoProduto();
                break;
        }
    }
}