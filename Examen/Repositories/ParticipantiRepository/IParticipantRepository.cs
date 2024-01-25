using Examen.Models.Participanti;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.ParticipantiRepository
{
    public interface IParticipantiRepository : IGenericRepository<Participanti>
    {
        Task<Participanti> GetByNameAsync(string name);
    }
}
