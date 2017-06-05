using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;


namespace DiscountCrazyAdmin.Data
{
    public class CodeRepository : Repository<Code>, IRepository<Code>
    {
        public CodeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
