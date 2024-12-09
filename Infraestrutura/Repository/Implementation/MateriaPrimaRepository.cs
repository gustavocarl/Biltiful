using Infraestrutura.Config;
using Infraestrutura.Entities;
using Infraestrutura.Repository.Contract;

namespace Infraestrutura.Repository.Implementation;

public class MateriaPrimaRepository : IMateriaPrimaRepository
{
    private readonly DatabaseContext _databaseContext;

    public MateriaPrimaRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public bool MateriaPrimaCadastrada(string nome)
    {
        var materiaPrima = _databaseContext.MateriaPrima.FirstOrDefault(mp => mp.Nome == nome);

        if (materiaPrima == null)
        {
            return false;
        }

        return true;
    }

    public Task<MateriaPrima> LocalizarMateriaPrima(MateriaPrima materiaPrima)
    {
        throw new NotImplementedException();
    }

    public async Task<MateriaPrima> CadastrarMateriaPrima(MateriaPrima materiaPrima)
    {
        _databaseContext.Add(materiaPrima);
        await _databaseContext.SaveChangesAsync();
        return materiaPrima;
    }

    public Task<MateriaPrima> AtualizarMateriaPrima(MateriaPrima materiaPrima)
    {
        throw new NotImplementedException();
    }

    public Task<MateriaPrima> InativarMateriaPrima(MateriaPrima materiaPrima)
    {
        throw new NotImplementedException();
    }
}