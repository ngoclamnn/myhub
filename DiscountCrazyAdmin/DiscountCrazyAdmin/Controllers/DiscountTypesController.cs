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
    public class DiscountTypesController : ApiController
    {
        private readonly IDiscountService _discountService;
        public DiscountTypesController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public DiscountType Get(int id)
        {
            return _discountService.GetDiscountTypeById(id);
        }
    }
}
