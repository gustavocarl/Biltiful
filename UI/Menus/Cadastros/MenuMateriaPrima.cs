using CadastrosBasicos.Services.Commands.MateriaPrima;

namespace UI.Menus.Cadastros;

public class MenuMateriaPrima
{
    public void ShowMenuMateriaPrima()
    {
        var cadastroBasicoMenu = new CadastrosBasicosMenu();
        var materiaPrimaService = new CadastrarMateriaPrima();

        Console.Clear();

        Console.WriteLine("================================");
        Console.WriteLine("Menu Gestão de Materia-Prima");
        Console.WriteLine("================================");
        Console.WriteLine("1 - Cadastrar Nova Matéria-Prima");
        Console.WriteLine("2 - Localizar Matéria-Prima");
        Console.WriteLine("3 - Editar Matéria-Prima");
        Console.WriteLine("4 - Inativar Matéria-Prima");
        Console.WriteLine("================================");
        Console.WriteLine("0 - Voltar ao Menu anterior");
        Console.WriteLine("================================");

        switch (Console.ReadLine())
        {
            case "0":
                cadastroBasicoMenu.ShowMenuCadastroBasico();
                break;

            case "1":
                materiaPrimaService.CadastrarNovaMateriaPrima();
                break;
        }
    }
}