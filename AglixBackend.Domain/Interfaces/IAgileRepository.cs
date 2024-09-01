using AglixBackend.Domain.Entities;

namespace AglixBackend.Domain.Interfaces
{
    public interface IAgileRepository
    {
        Task<Agile> GetByIdAsync(int id);
        Task<IEnumerable<Agile>> GetAllAsync();
        Task AddAsync (Agile agile);
        Task DeleteAsync (int id);  
        Task UpdateAsync (Agile agile);

    }
}
