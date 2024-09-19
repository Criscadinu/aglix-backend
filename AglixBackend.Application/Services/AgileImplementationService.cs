using AglixBackend.Application.Interfaces;
using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;

namespace AglixBackend.Application.Services
{
    public class AgileImplementationService : IAgileImplementationService
    {
        private readonly IAgileImplementationRepository _repository;

        public AgileImplementationService(IAgileImplementationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AgileImplementation>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<AgileImplementation> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(AgileImplementation agileImplementation)
        {
            await _repository.AddAsync(agileImplementation);
        }

        public async Task UpdateAsync(AgileImplementation agileImplementation)
        {
            await _repository.UpdateAsync(agileImplementation);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
