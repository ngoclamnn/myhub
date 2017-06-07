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
    public class PromotionsController : ApiController
    {
        private readonly IDiscountService _discountService;
        public PromotionsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public Promotion Get(int id)
        {
            return _discountService.GetPromotionById(id);
        }
    }
}
