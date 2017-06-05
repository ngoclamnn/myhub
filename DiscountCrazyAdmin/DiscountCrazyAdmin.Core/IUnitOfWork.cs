using System;
using System.Data.Entity;

namespace DiscountCrazyAdmin.Core
{
    public interface IUnitOfWork : IDisposable
    {
        DbSet<T> Set<T>() where T : class;

        void Save();

    }
}