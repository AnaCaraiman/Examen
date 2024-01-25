using Examen.Models.Evenimente;

namespace Examen.Service.EvenimenteService
{
    public interface IEvenimenteService
    {
        Task<IEnumerable<Evenimente>> GetAllEvenimente();
        Task<Evenimente> CreateEvenimente(Evenimente evenimente);
        Task<Evenimente> DeleteEvenimente(string name);
        Task<Evenimente> GetByNameAsync(string name);
        Task<Evenimente> UpdateEvenimente(Evenimente evenimente);
    }
}
