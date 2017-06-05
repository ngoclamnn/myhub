using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class BusinessCategoryReposittory : Repository<BusinessCategory>, IRepository<BusinessCategory>
    {
        private readonly IUnitOfWork _unitOfWork;
    }
}
