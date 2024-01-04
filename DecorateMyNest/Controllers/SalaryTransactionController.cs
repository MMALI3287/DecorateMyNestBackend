using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/salaryTransactions")]
    public class SalaryTransactionController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var SalaryTransactions = SalaryTransactionService.GetSalaryTransactions();
                return Ok(SalaryTransactions);
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
                var SalaryTransaction = SalaryTransactionService.GetSalaryTransactionById(id);
                return Ok(SalaryTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(SalaryTransactionDTO obj)
        {
            try
            {
                var createdSalaryTransaction = SalaryTransactionService.CreateSalaryTransaction(obj);
                return Ok(createdSalaryTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<SalaryTransactionDTO> SalaryTransactions)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(SalaryTransactionDTO obj)
        {
            try
            {
                var updatedSalaryTransaction = SalaryTransactionService.UpdateSalaryTransaction(obj);
                return Ok(updatedSalaryTransaction);
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
                var result = SalaryTransactionService.DeleteSalaryTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
