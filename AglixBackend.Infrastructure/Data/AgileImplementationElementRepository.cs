using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;
using AglixBackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AglixBackend.Infrastructure.Repositories
{
    public class AgileImplementationElementRepository : IAgileImplementationElementRepository
    {
        private readonly ApplicationDbContext _context;

        public AgileImplementationElementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all AgileImplementationElements
        public async Task<IEnumerable<AgileImplementationElement>> GetAllAsync()
        {
            return await _context.AgileImplementationElement.ToListAsync();
        }

        // Get a specific AgileImplementationElement by ID
        public async Task<AgileImplementationElement> GetByIdAsync(int id)
        {
            return await _context.AgileImplementationElement.FindAsync(id);
        }

        // Add a new AgileImplementationElement
        public async Task AddAsync(AgileImplementationElement element)
        {
            await _context.AgileImplementationElement.AddAsync(element);
            await _context.SaveChangesAsync();
        }

        // Update an existing AgileImplementationElement
        public async Task UpdateAsync(AgileImplementationElement element)
        {
            _context.Entry(element).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete an AgileImplementationElement by ID
        public async Task DeleteAsync(int id)
        {
            var element = await _context.AgileImplementationElement.FindAsync(id);
            if (element != null)
            {
                _context.AgileImplementationElement.Remove(element);
                await _context.SaveChangesAsync();
            }
        }
    }
}
