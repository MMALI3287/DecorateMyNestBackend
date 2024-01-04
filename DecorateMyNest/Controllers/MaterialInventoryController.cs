using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/materialInventories")]
    public class MaterialInventoryController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var MaterialInventorys = MaterialInventoryService.GetMaterialInventorys();
                return Ok(MaterialInventorys);
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
                var MaterialInventory = MaterialInventoryService.GetMaterialInventoryById(id);
                return Ok(MaterialInventory);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(MaterialInventoryDTO obj)
        {
            try
            {
                var createdMaterialInventory = MaterialInventoryService.CreateMaterialInventory(obj);
                return Ok(createdMaterialInventory);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<MaterialInventoryDTO> MaterialInventories)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(MaterialInventoryDTO obj)
        {
            try
            {
                var updatedMaterialInventory = MaterialInventoryService.UpdateMaterialInventory(obj);
                return Ok(updatedMaterialInventory);
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
                var result = MaterialInventoryService.DeleteMaterialInventory(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
