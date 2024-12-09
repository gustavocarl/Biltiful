using Infraestrutura.Entities;

namespace Infraestrutura.Repository.Contract;

public interface IMateriaPrimaRepository
{
    bool MateriaPrimaCadastrada(string nome);

    Task<MateriaPrima> LocalizarMateriaPrima(MateriaPrima materiaPrima);

    Task<MateriaPrima> CadastrarMateriaPrima(MateriaPrima materiaPrima);

    Task<MateriaPrima> AtualizarMateriaPrima(MateriaPrima materiaPrima);

    Task<MateriaPrima> InativarMateriaPrima(MateriaPrima materiaPrima);
}