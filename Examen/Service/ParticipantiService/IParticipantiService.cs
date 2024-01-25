using Examen.Models.Participanti;

namespace Examen.Service.ParticipantiService
{
    public interface IParticipantiService
    {
        Task<IEnumerable<Participanti>> GetAllParticipanti();
        Task<Participanti> CreateParticipanti(Participanti participanti);
        Task<Participanti> DeleteParticipanti(string name);
        Task<Participanti> GetByNameAsync(string name);
        Task<Participanti> UpdateParticipanti(Participanti participanti);
    }
}
