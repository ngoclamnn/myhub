using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
