﻿using AglixBackend.Domain.Entities;

namespace AglixBackend.Domain.Interfaces
{
    public interface IAgileImplementationRepository
    {
        Task<IEnumerable<AgileImplementation>> GetAllAsync();
        Task<AgileImplementation> GetByIdAsync(int id);
        Task AddAsync(AgileImplementation agileImplementation);
        Task UpdateAsync(AgileImplementation agileImplementation);
        Task DeleteAsync(int id);
    }
}
