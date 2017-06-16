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
    public class BusinessCategoriesController : ApiController
    {
        private readonly IApplicationService _applicationService;
        public BusinessCategoriesController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public BusinessCategory Get(int id)
        {
            return _applicationService.GetBusinessCategoryById(id);
        }

        [HttpPost]
        public BusinessCategory Create(BusinessCategory entity)
        {
            entity.created = DateTime.Now;
            entity.modified = DateTime.Now;
            entity = _applicationService.CreateBusinessCategory(entity);
            _applicationService.SaveBusinessCategory();
            return entity;
        }

        [HttpPut]
        public BusinessCategory Update(BusinessCategory entity)
        {
            entity.modified = DateTime.Now;
            entity = _applicationService.UpdateBusinessCategory(entity);
            _applicationService.SaveBusinessCategory();
            return entity;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _applicationService.DeleteBusinessCategory(id);
            _applicationService.SaveBusinessCategory();
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
