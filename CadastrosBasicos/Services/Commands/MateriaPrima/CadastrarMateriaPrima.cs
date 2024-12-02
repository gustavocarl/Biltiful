namespace CadastrosBasicos.Services.Commands.MateriaPrima;

public class CadastrarMateriaPrima
{
    public void CadastrarNovaMateriaPrima()
    {
        string nome;

        Guid id = Guid.NewGuid();

        do
        {
            Console.WriteLine("Informe o Nome da Matéria-Prima");
            nome = Console.ReadLine()!;
        } while (!Validacoes.ValidacoesMateriaPrima.ValidarNomeMateriaPrima(nome));

        DateOnly ultimaCompra = DateOnly.FromDateTime(DateTime.Now);

        DateOnly dataCadastro = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';

        var materiaPrima = new Models.MateriaPrima(id, nome, ultimaCompra, dataCadastro, situacao);

        Console.WriteLine(materiaPrima.ImprimirMateriaPrima());
    }
}