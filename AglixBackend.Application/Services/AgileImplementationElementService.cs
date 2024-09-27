using AglixBackend.Application.Interfaces;
using AglixBackend.Domain.Entities;
using AglixBackend.Domain.Interfaces;

namespace AglixBackend.Application.Services
{
    public class AgileImplementationElementService : IAgileImplementationElementService
    {
        private readonly IAgileImplementationElementRepository _repository;

        public AgileImplementationElementService(IAgileImplementationElementRepository repository)
        {
            _repository = repository;
        }

        // Retrieve all elements by AgileImplementationId
        public async Task<IEnumerable<AgileImplementationElement>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        // Get element by Id
        public async Task<AgileImplementationElement> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        // Add a new element
        public async Task AddAsync(AgileImplementationElement agileElement)
        {
            await _repository.AddAsync(agileElement);
        }

        // Update an existing element
        public async Task UpdateAsync(AgileImplementationElement agileElement)
        {
            await _repository.UpdateAsync(agileElement);
        }

        // Delete element by Id
        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public Task<IEnumerable<AgileImplementationElement>> GetAllByImplementationIdAsync(int implementationId)
        {
            throw new NotImplementedException();
        }
    }
}
