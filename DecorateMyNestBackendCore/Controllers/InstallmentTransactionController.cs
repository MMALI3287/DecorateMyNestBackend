using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/installmentTransactions")]
    public class InstallmentTransactionController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/installmentTransactions/")]
        public IActionResult Get()
        {
            try
            {
                var InstallmentTransactions = InstallmentTransactionService.GetInstallmentTransactions();
                return Ok(InstallmentTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/installmentTransactions/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var InstallmentTransaction = InstallmentTransactionService.GetInstallmentTransactionById(id);
                return Ok(InstallmentTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/installmentTransactions/")]
        public IActionResult Create(InstallmentTransactionDTO obj)
        {
            try
            {
                var createdInstallmentTransaction = InstallmentTransactionService.CreateInstallmentTransaction(obj);
                return Ok(createdInstallmentTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/installmentTransactions/create-multiple")]
        public IActionResult Create(List<InstallmentTransactionDTO> InstallmentTransactions)
        {
            try
            {
                var createdInstallmentTransactions = new List<InstallmentTransactionDTO>();

                foreach (var InstallmentTransaction in InstallmentTransactions)
                {
                    var createdInstallmentTransaction = InstallmentTransactionService.CreateInstallmentTransaction(InstallmentTransaction);
                    createdInstallmentTransactions.Add(createdInstallmentTransaction);
                }

                return Ok(createdInstallmentTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/installmentTransactions/")]
        public IActionResult Update(InstallmentTransactionDTO obj)
        {
            try
            {
                var updatedInstallmentTransaction = InstallmentTransactionService.UpdateInstallmentTransaction(obj);
                return Ok(updatedInstallmentTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/installmentTransactions/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = InstallmentTransactionService.DeleteInstallmentTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
