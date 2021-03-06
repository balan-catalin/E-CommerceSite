﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specification;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : EntityBase
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}
