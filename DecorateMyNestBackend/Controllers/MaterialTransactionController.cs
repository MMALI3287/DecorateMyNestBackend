using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/materialTransactions")]
    public class MaterialTransactionController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var MaterialTransactions = MaterialTransactionService.GetMaterialTransactions();
                return Ok(MaterialTransactions);
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
                var MaterialTransaction = MaterialTransactionService.GetMaterialTransactionById(id);
                return Ok(MaterialTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(MaterialTransactionDTO obj)
        {
            try
            {
                var createdMaterialTransaction = MaterialTransactionService.CreateMaterialTransaction(obj);
                return Ok(createdMaterialTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<MaterialTransactionDTO> MaterialTransactions)
        {
            try
            {
                var createdMaterialTransactions = new List<MaterialTransactionDTO>();

                foreach (var MaterialTransaction in MaterialTransactions)
                {
                    var createdMaterialTransaction = MaterialTransactionService.CreateMaterialTransaction(MaterialTransaction);
                    createdMaterialTransactions.Add(createdMaterialTransaction);
                }

                return Ok(createdMaterialTransactions);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(MaterialTransactionDTO obj)
        {
            try
            {
                var updatedMaterialTransaction = MaterialTransactionService.UpdateMaterialTransaction(obj);
                return Ok(updatedMaterialTransaction);
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
                var result = MaterialTransactionService.DeleteMaterialTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
