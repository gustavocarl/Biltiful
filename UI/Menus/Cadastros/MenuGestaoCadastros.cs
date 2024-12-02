namespace UI.Menus.Cadastros
{
    public class CadastrosBasicosMenu
    {
        public void ShowMenuCadastroBasico()
        {
            var cadastroBasicoCliente = new MenuCliente();
            var cadastroBasicoFornecedor = new MenuFornecedor();
            var cadastroBasicoMateriaPrima = new MenuMateriaPrima();
            var cadastroBasicoProduto = new MenuProduto();

            Console.Clear();

            Console.WriteLine("===========================");
            Console.WriteLine("Menu de Gestão Geral");
            Console.WriteLine("===========================");
            Console.WriteLine("1 - Gestão de Cliente");
            Console.WriteLine("2 - Gestão de Fornecedor");
            Console.WriteLine("3 - Gestão de Matéria-Prima");
            Console.WriteLine("4 - Gestão de Produto");
            Console.WriteLine("===========================");
            Console.WriteLine("0 - Voltar ao Menu Anterior");
            Console.WriteLine("===========================");

            switch (Console.ReadLine())
            {
                case "0":
                    MenuPrincipal.MenuPrincipal.ShowMainMenu();
                    break;

                case "1":
                    cadastroBasicoCliente.ShowMenuCliente();
                    break;

                case "2":
                    cadastroBasicoFornecedor.ShowMenuFornecedor();
                    break;

                case "3":
                    cadastroBasicoMateriaPrima.ShowMenuMateriaPrima();
                    break;

                case "4":
                    cadastroBasicoProduto.ShowMenuProduto();
                    break;

                default:
                    break;
            }
        }
    }
}