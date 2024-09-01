using AglixBackend.Domain.Entities;

namespace AglixBackend.Application.Interfaces
{
    public interface IAgileService
    {
        Task<Agile> GetByIdAsync(int id);
        Task<IEnumerable<Agile>> GetAllAsync();
        Task AddAsync(Agile agile);
        Task UpdateAsync(Agile agile);
        Task DeleteAsync(int id);
    }
}
