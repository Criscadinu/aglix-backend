using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public async Task AddAsync(Agile agile)
        {
            _context.Agile.Add(agile);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var agile = await _context.Agile.FindAsync(id);
            if (agile != null)
            {
                _context.Agile.Remove(agile);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Agile>> GetAllAsync()
        {
            return await _context.Agile.ToListAsync();
        }

        public async Task<Agile> GetByIdAsync(int id)
        {
            return await _context.Agile.FindAsync(id);
        }

        public async Task UpdateAsync(Agile agile)
        {
            _context.Agile.Update(agile);
            await _context.SaveChangesAsync();
        }
    }
}
