using AglixBackend.Domain.Entities;

namespace AglixBackend.Domain.Interfaces
{
    public interface IAgileImplementationElementRepository
    {
        Task<IEnumerable<AgileImplementationElement>> GetAllAsync();
        Task<AgileImplementationElement> GetByIdAsync(int id);
        Task AddAsync(AgileImplementationElement element);
        Task UpdateAsync(AgileImplementationElement element);
        Task DeleteAsync(int id);
    }
}
