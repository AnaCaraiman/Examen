using Examen.Models.Participanti;
using Examen.Repositories.ParticipantiRepository;


namespace Examen.Service.ParticipantiService
{
    public class ParticipantiService : IParticipantiService
    {
        private readonly IParticipantiRepository _participantiRepository;

        public ParticipantiService(IParticipantiRepository participantiRepository)
        {
            _participantiRepository = participantiRepository;
        }

        public async Task<IEnumerable<Participanti>> GetAllParticipanti()
        {
            return await _participantiRepository.GetAllAsync();
        }

        public async Task<Participanti> CreateParticipanti(Participanti participanti)
        {
            await _participantiRepository.CreateAsync(participanti);
            await _participantiRepository.SaveAsync();
            return participanti;
        }

        public async Task<Participanti> DeleteParticipanti(string name)
        {
            var participanti = await _participantiRepository.GetByNameAsync(name);
            _participantiRepository.Delete(participanti);
            await _participantiRepository.SaveAsync();
            return participanti;
        }

        public async Task<Participanti> GetByNameAsync(string name)
        {
            return await _participantiRepository.GetByNameAsync(name);
        }

        public async Task<Participanti> UpdateParticipanti(Participanti participanti)
        {
            _participantiRepository.Update(participanti);
            await _participantiRepository.SaveAsync();
            return participanti;
        }

       
    }
    }
