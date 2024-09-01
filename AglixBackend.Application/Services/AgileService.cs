using AglixBackend.Application.Interfaces;
using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;

namespace AglixBackend.Application.Services
{
    public class AgileService : IAgileService
    {
        private readonly IAgileRepository _agileRepository;

        public AgileService(IAgileRepository agileRepository)
        {
            _agileRepository = agileRepository;
        }

        public async Task<Agile> GetByIdAsync(int id)
        {
            return await _agileRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Agile>> GetAllAsync()
        {
            return await _agileRepository.GetAllAsync();
        }

        public async Task AddAsync(Agile agile)
        {
            await _agileRepository.AddAsync(agile);
        }

        public async Task UpdateAsync(Agile agile)
        {
            await _agileRepository.UpdateAsync(agile);
        }

        public async Task DeleteAsync(int id)
        {
            await _agileRepository.DeleteAsync(id);
        }
    }
}
