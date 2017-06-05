using DiscountCrazyAdmin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class BusinessCategoryReposittory : IRepository<>,
    {
        private readonly IUnitOfWork _unitOfWork;
    }
}
