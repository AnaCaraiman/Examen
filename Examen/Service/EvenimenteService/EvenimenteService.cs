using Examen.Models.Evenimente;
using Examen.Repositories.EvenimenteRepository;

namespace Examen.Service.EvenimenteService
{

    public class EvenimenteService : IEvenimenteService
    {
        private readonly IEvenimenteRepository _evenimenteRepository;

        public EvenimenteService(IEvenimenteRepository evenimenteRepository)
        {
            _evenimenteRepository = evenimenteRepository;
        }

        public async Task<IEnumerable<Evenimente>> GetAllEvenimente()
        {
            return await _evenimenteRepository.GetAllAsync();
        }

        public async Task<Evenimente> CreateEvenimente(Evenimente evenimente)
        {
            await _evenimenteRepository.CreateAsync(evenimente);
            await _evenimenteRepository.SaveAsync();
            return evenimente;
        }

        public async Task<Evenimente> DeleteEvenimente(string name)
        {
            var evenimente = await _evenimenteRepository.GetByNameAsync(name);
            _evenimenteRepository.Delete(evenimente);
            await _evenimenteRepository.SaveAsync();
            return evenimente;
        }

        public async Task<Evenimente> GetByNameAsync(string name)
        {
            return await _evenimenteRepository.GetByNameAsync(name);
        }

        public async Task<Evenimente> UpdateEvenimente(Evenimente evenimente)
        {
            _evenimenteRepository.Update(evenimente);
            await _evenimenteRepository.SaveAsync();
            return evenimente;
        }


    }
}
