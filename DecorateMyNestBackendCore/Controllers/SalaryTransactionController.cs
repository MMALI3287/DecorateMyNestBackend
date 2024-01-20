using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/salaryTransactions")]
    public class SalaryTransactionController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/salaryTransactions/")]
        public IActionResult Get()
        {
            try
            {
                var SalaryTransactions = SalaryTransactionService.GetSalaryTransactions();
                return Ok(SalaryTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/salaryTransactions/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var SalaryTransaction = SalaryTransactionService.GetSalaryTransactionById(id);
                return Ok(SalaryTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/salaryTransactions/")]
        public IActionResult Create(SalaryTransactionDTO obj)
        {
            try
            {
                var createdSalaryTransaction = SalaryTransactionService.CreateSalaryTransaction(obj);
                return Ok(createdSalaryTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/salaryTransactions/create-multiple")]
        public IActionResult Create(List<SalaryTransactionDTO> SalaryTransactions)
        {
            try
            {
                var createdSalaryTransactions = new List<SalaryTransactionDTO>();

                foreach (var SalaryTransaction in SalaryTransactions)
                {
                    var createdSalaryTransaction = SalaryTransactionService.CreateSalaryTransaction(SalaryTransaction);
                    createdSalaryTransactions.Add(createdSalaryTransaction);
                }

                return Ok(createdSalaryTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/salaryTransactions/")]
        public IActionResult Update(SalaryTransactionDTO obj)
        {
            try
            {
                var updatedSalaryTransaction = SalaryTransactionService.UpdateSalaryTransaction(obj);
                return Ok(updatedSalaryTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/salaryTransactions/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = SalaryTransactionService.DeleteSalaryTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
