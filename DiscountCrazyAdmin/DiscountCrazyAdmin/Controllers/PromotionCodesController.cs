using DiscountCrazyAdmin.Data.Entities;
using DiscountCrazyAdmin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiscountCrazyAdmin.Controllers
{
    public class BusinessCategoryController : ApiController
    {
        private readonly IApplicationService _applicationService;
        private readonly IDiscountService _discountService;

        public BusinessCategoryController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public BusinessCategory Get(int id)
        {
            return _discountService.GetPromotionCodeById(id);
        }
    }
}
