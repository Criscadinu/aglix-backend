using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;

namespace AglixBackend.Infrastructure.Data
{
    public class AgileRepository : IAgileRepository
    {

        private readonly ApplicationDbContext _context;

        public AgileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext Context { get; }

        public Task AddAsync(Agile agile)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Agile>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Agile> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Agile agile)
        {
            throw new NotImplementedException();
        }
    }
}
