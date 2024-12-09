using Infraestrutura.Config;
using Infraestrutura.Repository.Contract;
using Infraestrutura.Repository.Implementation;

namespace CadastrosBasicos.Services.Commands.MateriaPrima;

public class CadastrarMateriaPrima
{
    private readonly IMateriaPrimaRepository _materiaPrimaRepository;

    public CadastrarMateriaPrima()
    {
        _materiaPrimaRepository = new MateriaPrimaRepository(new DatabaseContext());
    }

    public void CadastrarNovaMateriaPrima()
    {
        string nome;

        Guid id = Guid.NewGuid();

        do
        {
            Console.WriteLine("Informe o Nome da Matéria-Prima");
            nome = Console.ReadLine()!;
        } while (!Validacoes.ValidacoesMateriaPrima.ValidarNomeMateriaPrima(nome) || _materiaPrimaRepository.MateriaPrimaCadastrada(nome));

        DateOnly ultimaCompra = DateOnly.FromDateTime(DateTime.Now);

        DateOnly dataCadastro = DateOnly.FromDateTime(DateTime.Now);

        char situacao = 'A';

        var materiaPrima = new Infraestrutura.Entities.MateriaPrima(id, nome, ultimaCompra, dataCadastro, situacao);

        _materiaPrimaRepository.CadastrarMateriaPrima(materiaPrima);

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}