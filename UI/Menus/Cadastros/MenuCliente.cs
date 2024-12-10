using CadastrosBasicos.Services.Commands.Cliente;
using CadastrosBasicos.Services.Queries.Cliente;

namespace UI.Menus.Cadastros;

public class MenuCliente
{
    public void ShowMenuCliente()
    {
        var cadastroBasicoMenu = new CadastrosBasicosMenu();
        var cadastrarCliente = new CadastrarCliente();
        var inativarCliente = new InativarCliente();
        var atualizarCliente = new AtualizarCliente();
        var localizarCliente = new BuscarCliente();

        Console.Clear();

        Console.WriteLine("===========================");
        Console.WriteLine("Menu Gestão de Clientes;");
        Console.WriteLine("===========================");
        Console.WriteLine("1 - Cadastrar Novo Cliente");
        Console.WriteLine("2 - Localizar Cliente");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Inativar Cliente");
        Console.WriteLine("===========================");
        Console.WriteLine("0 - Voltar ao Menu anterior");
        Console.WriteLine("===========================");

        switch (Console.ReadLine())
        {
            case "0":
                cadastroBasicoMenu.ShowMenuCadastroBasico();
                break;

            case "1":
                cadastrarCliente.CadastrarNovoCliente();
                ShowMenuCliente();
                break;

            case "2":
                localizarCliente.LocalizarCliente();
                break;

            case "3":
                atualizarCliente.AtualizarClienteCadastrado();
                ShowMenuCliente();
                break;

            case "4":
                inativarCliente.InativarClienteCadastrado();
                ShowMenuCliente();
                break;

            default:
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                ShowMenuCliente();
                break;
        }
    }
}