using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/materialTransactions")]
    public class MaterialTransactionController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/materialTransactions/")]
        public IActionResult Get()
        {
            try
            {
                var MaterialTransactions = MaterialTransactionService.GetMaterialTransactions();
                return Ok(MaterialTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/materialTransactions/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var MaterialTransaction = MaterialTransactionService.GetMaterialTransactionById(id);
                return Ok(MaterialTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/materialTransactions/")]
        public IActionResult Create(MaterialTransactionDTO obj)
        {
            try
            {
                var createdMaterialTransaction = MaterialTransactionService.CreateMaterialTransaction(obj);
                return Ok(createdMaterialTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/materialTransactions/create-multiple")]
        public IActionResult Create(List<MaterialTransactionDTO> MaterialTransactions)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/materialTransactions/")]
        public IActionResult Update(MaterialTransactionDTO obj)
        {
            try
            {
                var updatedMaterialTransaction = MaterialTransactionService.UpdateMaterialTransaction(obj);
                return Ok(updatedMaterialTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/materialTransactions/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = MaterialTransactionService.DeleteMaterialTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
