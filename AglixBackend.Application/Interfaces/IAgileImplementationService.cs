using AglixBackend.Domain.Entities;

namespace AglixBackend.Application.Interfaces
{
    public interface IAgileImplementationService
    {
        Task<IEnumerable<AgileImplementation>> GetAllAsync();
        Task<AgileImplementation> GetByIdAsync(int id);
        Task AddAsync(AgileImplementation agileImplementation);
        Task UpdateAsync(AgileImplementation agileImplementation);
        Task DeleteAsync(int id);
    }
}
