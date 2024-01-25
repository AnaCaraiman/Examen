using Examen.Data;
using Examen.Models.Participanti;
using Examen.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.ParticipantiRepository
{

    public class ParticipantiRepository : GenericRepository<Participanti>, IParticipantiRepository
    {
        public ParticipantiRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Participanti> GetByNameAsync(string name)
        {

            return await _table.FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}
