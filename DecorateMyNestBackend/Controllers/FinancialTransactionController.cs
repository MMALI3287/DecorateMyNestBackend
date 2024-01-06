using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/financialTransactions")]
    public class FinancialTransactionController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var FinancialTransactions = FinancialTransactionService.GetFinancialTransactions();
                return Ok(FinancialTransactions);
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
                var FinancialTransaction = FinancialTransactionService.GetFinancialTransactionById(id);
                return Ok(FinancialTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(FinancialTransactionDTO obj)
        {
            try
            {
                var createdFinancialTransaction = FinancialTransactionService.CreateFinancialTransaction(obj);
                return Ok(createdFinancialTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<FinancialTransactionDTO> FinancialTransactions)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(FinancialTransactionDTO obj)
        {
            try
            {
                var updatedFinancialTransaction = FinancialTransactionService.UpdateFinancialTransaction(obj);
                return Ok(updatedFinancialTransaction);
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
                var result = FinancialTransactionService.DeleteFinancialTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
