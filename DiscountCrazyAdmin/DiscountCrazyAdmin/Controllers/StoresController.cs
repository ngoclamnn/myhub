﻿using DiscountCrazyAdmin.Data.Entities;
using DiscountCrazyAdmin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiscountCrazyAdmin.Controllers
{
    public class StoresController : ApiController
    {
        private readonly IApplicationService _applicationService;
        public StoresController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public BusinessCategory Get(int id)
        {
            return _applicationService.GetBusinessCategoryById(id);
        }
    }
}
