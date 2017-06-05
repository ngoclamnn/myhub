using System.Linq;

namespace DiscountCrazyAdmin.Core
{
    public interface IRepository<T>

    {

        T GetById(int id);

        IQueryable<T> GetAll();

        void Update(T entity);

        void Insert(T entity);

        void Delete(T entity);

    }
}