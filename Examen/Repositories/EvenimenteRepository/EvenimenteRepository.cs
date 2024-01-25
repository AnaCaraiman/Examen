using Examen.Data;
using Examen.Models.Evenimente;
using Examen.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.EvenimenteRepository
{
    public class EvenimenteRepository : GenericRepository<Evenimente>, IEvenimenteRepository
    {
        public EvenimenteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Evenimente> GetByNameAsync(string name)
        {
            return await _table.FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}
