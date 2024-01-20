using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/materialInventories")]
    public class MaterialInventoryController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/materialInventories/")]
        public IActionResult Get()
        {
            try
            {
                var MaterialInventorys = MaterialInventoryService.GetMaterialInventorys();
                return Ok(MaterialInventorys);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/materialInventories/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var MaterialInventory = MaterialInventoryService.GetMaterialInventoryById(id);
                return Ok(MaterialInventory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/materialInventories/")]
        public IActionResult Create(MaterialInventoryDTO obj)
        {
            try
            {
                var createdMaterialInventory = MaterialInventoryService.CreateMaterialInventory(obj);
                return Ok(createdMaterialInventory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/materialInventories/create-multiple")]
        public IActionResult Create(List<MaterialInventoryDTO> MaterialInventories)
        {
            try
            {
                var createdMaterialInventorys = new List<MaterialInventoryDTO>();

                foreach (var MaterialInventory in MaterialInventories)
                {
                    var createdMaterialInventory = MaterialInventoryService.CreateMaterialInventory(MaterialInventory);
                    createdMaterialInventorys.Add(createdMaterialInventory);
                }

                return Ok(createdMaterialInventorys);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/materialInventories/")]
        public IActionResult Update(MaterialInventoryDTO obj)
        {
            try
            {
                var updatedMaterialInventory = MaterialInventoryService.UpdateMaterialInventory(obj);
                return Ok(updatedMaterialInventory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/materialInventories/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = MaterialInventoryService.DeleteMaterialInventory(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
