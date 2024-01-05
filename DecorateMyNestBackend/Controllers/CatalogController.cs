using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/catalogs")]
    public class CatalogController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Catalogs = CatalogService.GetCatalogs();
                return Ok(Catalogs);
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
                var Catalog = CatalogService.GetCatalogById(id);
                return Ok(Catalog);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(CatalogDTO obj)
        {
            try
            {
                var createdCatalog = CatalogService.CreateCatalog(obj);
                return Ok(createdCatalog);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<CatalogDTO> Catalogs)
        {
            try
            {
                var createdCatalogs = new List<CatalogDTO>();

                foreach (var Catalog in Catalogs)
                {
                    var createdCatalog = CatalogService.CreateCatalog(Catalog);
                    createdCatalogs.Add(createdCatalog);
                }

                return Ok(createdCatalogs);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(CatalogDTO obj)
        {
            try
            {
                var updatedCatalog = CatalogService.UpdateCatalog(obj);
                return Ok(updatedCatalog);
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
                var result = CatalogService.DeleteCatalog(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
