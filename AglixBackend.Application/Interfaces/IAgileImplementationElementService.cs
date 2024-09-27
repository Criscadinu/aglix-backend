using AglixBackend.Domain.Entities;

namespace AglixBackend.Application.Interfaces
{
    public interface IAgileImplementationElementService
    {
        // Retrieve all elements for a specific Agile Implementation (e.g., Scrum, Kanban)
        Task<IEnumerable<AgileImplementationElement>> GetAllAsync();

        // Get a specific element by its Id
        Task<AgileImplementationElement> GetByIdAsync(int id);

        // Add a new element
        Task AddAsync(AgileImplementationElement agileElement);

        // Update an existing element
        Task UpdateAsync(AgileImplementationElement agileElement);

        // Delete an element by its Id
        Task DeleteAsync(int id);
    }
}
