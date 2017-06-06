using DiscountCrazyAdmin.Data;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IBusinessCategoryRepository _businessCategoryRepository;
        public ApplicationService(IBusinessCategoryRepository businessCategoryRepository)
        {
            _businessCategoryRepository = businessCategoryRepository;
        }

        public BusinessCategory GetBusinessCategoryById(int businessCategoryId)
        {
            return _businessCategoryRepository.GetById(businessCategoryId);
        }
    }

    public interface IApplicationService
    {
        BusinessCategory GetBusinessCategoryById(int businessCategoryId);
    }
}
