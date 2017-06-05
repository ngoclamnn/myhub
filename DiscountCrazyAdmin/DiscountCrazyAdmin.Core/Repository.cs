using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _dbset;
        private readonly DbContext _dbContext;
        public Repository(IUnitOfWork unitOfWork)
        {
            _dbset = unitOfWork.Set<T>();
            _dbContext = unitOfWork.DbContext;
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);
        }


        public IQueryable<T> GetAll()
        {
            return _dbset;
        }

        public void Insert(T entity)
        {
            _dbset.Add(entity);
        }


        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }

    }
}
