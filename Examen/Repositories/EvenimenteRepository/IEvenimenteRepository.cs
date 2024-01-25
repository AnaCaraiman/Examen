using Examen.Models.Evenimente;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.EvenimenteRepository
{
    public interface IEvenimenteRepository : IGenericRepository<Evenimente>

    {
        Task<Evenimente> GetByNameAsync(string name);
    }
}
