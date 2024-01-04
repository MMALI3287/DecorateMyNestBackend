using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/catalogCategories")]
    public class CatalogCategoryController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var CatalogCategorys = CatalogCategoryService.GetCatalogCategorys();
                return Ok(CatalogCategorys);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                var CatalogCategory = CatalogCategoryService.GetCatalogCategoryById(id);
                return Ok(CatalogCategory);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(CatalogCategoryDTO obj)
        {
            try
            {
                var createdCatalogCategory = CatalogCategoryService.CreateCatalogCategory(obj);
                return Ok(createdCatalogCategory);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<CatalogCategoryDTO> CatalogCategories)
        {
            try
            {
                var createdCatalogCategorys = new List<CatalogCategoryDTO>();

                foreach (var CatalogCategory in CatalogCategories)
                {
                    var createdCatalogCategory = CatalogCategoryService.CreateCatalogCategory(CatalogCategory);
                    createdCatalogCategorys.Add(createdCatalogCategory);
                }

                return Ok(createdCatalogCategorys);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(CatalogCategoryDTO obj)
        {
            try
            {
                var updatedCatalogCategory = CatalogCategoryService.UpdateCatalogCategory(obj);
                return Ok(updatedCatalogCategory);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var result = CatalogCategoryService.DeleteCatalogCategory(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
