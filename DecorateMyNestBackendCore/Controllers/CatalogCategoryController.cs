using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/catalogCategories")]
    public class CatalogCategoryController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/catalogCategories/")]
        public IActionResult Get()
        {
            try
            {
                var CatalogCategorys = CatalogCategoryService.GetCatalogCategorys();
                return Ok(CatalogCategorys);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/catalogCategories/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var CatalogCategory = CatalogCategoryService.GetCatalogCategoryById(id);
                return Ok(CatalogCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/catalogCategories/")]
        public IActionResult Create(CatalogCategoryDTO obj)
        {
            try
            {
                var createdCatalogCategory = CatalogCategoryService.CreateCatalogCategory(obj);
                return Ok(createdCatalogCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/catalogCategories/create-multiple")]
        public IActionResult Create(List<CatalogCategoryDTO> CatalogCategories)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/catalogCategories/")]
        public IActionResult Update(CatalogCategoryDTO obj)
        {
            try
            {
                var updatedCatalogCategory = CatalogCategoryService.UpdateCatalogCategory(obj);
                return Ok(updatedCatalogCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/catalogCategories/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = CatalogCategoryService.DeleteCatalogCategory(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
