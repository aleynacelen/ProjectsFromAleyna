using System;
using EShop.Entity.Concrete;

namespace EShop.Data.Abstract;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    int Save();
    Task<int> SaveAsync();
    Task<int> SaveAsync();
    public int MyProperty { get; set; }

}