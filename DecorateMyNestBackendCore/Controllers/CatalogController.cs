using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/catalogs")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/catalogs/")]
        public IActionResult Get()
        {
            try
            {
                var Catalogs = CatalogService.GetCatalogs();
                return Ok(Catalogs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/catalogs/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Catalog = CatalogService.GetCatalogById(id);
                return Ok(Catalog);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/catalogs/")]
        public IActionResult Create(CatalogDTO obj)
        {
            try
            {
                var createdCatalog = CatalogService.CreateCatalog(obj);
                return Ok(createdCatalog);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/catalogs/create-multiple")]
        public IActionResult Create(List<CatalogDTO> Catalogs)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/catalogs/")]
        public IActionResult Update(CatalogDTO obj)
        {
            try
            {
                var updatedCatalog = CatalogService.UpdateCatalog(obj);
                return Ok(updatedCatalog);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/catalogs/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = CatalogService.DeleteCatalog(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
