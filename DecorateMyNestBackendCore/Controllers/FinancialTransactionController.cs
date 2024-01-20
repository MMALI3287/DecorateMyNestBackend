using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/financialTransactions")]
    public class FinancialTransactionController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/financialTransactions/")]
        public IActionResult Get()
        {
            try
            {
                var FinancialTransactions = FinancialTransactionService.GetFinancialTransactions();
                return Ok(FinancialTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/financialTransactions/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var FinancialTransaction = FinancialTransactionService.GetFinancialTransactionById(id);
                return Ok(FinancialTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/financialTransactions/")]
        public IActionResult Create(FinancialTransactionDTO obj)
        {
            try
            {
                var createdFinancialTransaction = FinancialTransactionService.CreateFinancialTransaction(obj);
                return Ok(createdFinancialTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/financialTransactions/create-multiple")]
        public IActionResult Create(List<FinancialTransactionDTO> FinancialTransactions)
        {
            try
            {
                var createdFinancialTransactions = new List<FinancialTransactionDTO>();

                foreach (var FinancialTransaction in FinancialTransactions)
                {
                    var createdFinancialTransaction = FinancialTransactionService.CreateFinancialTransaction(FinancialTransaction);
                    createdFinancialTransactions.Add(createdFinancialTransaction);
                }

                return Ok(createdFinancialTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/financialTransactions/")]
        public IActionResult Update(FinancialTransactionDTO obj)
        {
            try
            {
                var updatedFinancialTransaction = FinancialTransactionService.UpdateFinancialTransaction(obj);
                return Ok(updatedFinancialTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/financialTransactions/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = FinancialTransactionService.DeleteFinancialTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
