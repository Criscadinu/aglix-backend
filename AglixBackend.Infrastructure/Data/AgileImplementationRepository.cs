using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;
using AglixBackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AglixBackend.Infrastructure.Repositories
{
    public class AgileImplementationRepository : IAgileImplementationRepository
    {
        private readonly ApplicationDbContext _context;

        public AgileImplementationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AgileImplementation>> GetAllAsync()
        {
            return await _context.AgileImplementation.ToListAsync();
        }

        public async Task<AgileImplementation> GetByIdAsync(int id)
        {
            return await _context.AgileImplementation.FindAsync(id);
        }

        public async Task AddAsync(AgileImplementation agileImplementation)
        {
            _context.AgileImplementation.Add(agileImplementation);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AgileImplementation agileImplementation)
        {
            _context.Entry(agileImplementation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var implementation = await _context.AgileImplementation.FindAsync(id);
            if (implementation != null)
            {
                _context.AgileImplementation.Remove(implementation);
                await _context.SaveChangesAsync();
            }
        }
    }
}
