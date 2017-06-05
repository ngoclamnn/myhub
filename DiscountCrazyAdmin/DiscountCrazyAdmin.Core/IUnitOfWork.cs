using System;
using System.Data.Entity;

namespace DiscountCrazyAdmin.Core
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext DbContext { get; set; }
        DbSet<T> Set<T>() where T : class;
        void Save();

    }
}