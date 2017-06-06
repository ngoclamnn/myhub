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
    public class CodesUsedController : ApiController
    {
        private readonly IDiscountService _discountService;
        public CodesUsedController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public CodeUsedHistory Get(int id)
        {
            return _discountService.GetCodeUsedHistoryById(id);
        }
    }
}
