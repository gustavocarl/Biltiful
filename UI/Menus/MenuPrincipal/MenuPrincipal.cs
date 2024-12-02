namespace UI.Menus.MenuPrincipal;

public class MenuPrincipal
{
    public static void ShowMainMenu()
    {
        var cadastroBasicoMenu = new Cadastros.CadastrosBasicosMenu();
        var vendaProdutos = new Produtos.MenuVendaProdutos();
        var compraMateriaPrima = new MateriaPrima.MenuCompraMateriaPrima();
        var producaoCosmeticos = new Producao.MenuProducaoCosmeticos();

        Console.Clear();

        Console.WriteLine("===========================");
        Console.WriteLine("Bem vindo ao Biltiful");
        Console.WriteLine("===========================");
        Console.WriteLine("Menu Principal");
        Console.WriteLine("===========================");
        Console.WriteLine("1 - Cadastros Básicos");
        Console.WriteLine("2 - Venda de Produtos");
        Console.WriteLine("3 - Compra de Matéria-Prima");
        Console.WriteLine("4 - Produção de Cosméticos");
        Console.WriteLine("===========================");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("===========================");

        switch (Console.ReadLine())
        {
            case "0":
                Environment.Exit(0);
                break;

            case "1":
                cadastroBasicoMenu.ShowMenuCadastroBasico();
                break;

            case "2":
                vendaProdutos.ShowMenuVendaProdutos();
                break;

            case "3":
                compraMateriaPrima.ShowMenuCompraMateriaPrima();
                break;

            case "4":
                producaoCosmeticos.ShowMenuProducaoCosmeticos();
                break;

            default:
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                ShowMainMenu();
                break;
        }
    }
}