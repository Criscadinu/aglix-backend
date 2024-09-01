using AglixBackend.Domain.Entities;

namespace AglixBackend.Domain.Interfaces
{
    public interface IAgileImplementationRepository
    {
        Task<AgileImplementation> GetByIdAsync(int id);
        Task<IEnumerable<AgileImplementation>> GetAllByAgileIdAsync(int agileId);
        Task AddAsync(AgileImplementation agileImplementation);
        Task UpdateAsync(AgileImplementation agileImplementation);
        Task DeleteAsync(int id);
    }
}
