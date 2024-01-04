using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/installmentTransactions")]
    public class InstallmentTransactionController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var InstallmentTransactions = InstallmentTransactionService.GetInstallmentTransactions();
                return Ok(InstallmentTransactions);
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
                var InstallmentTransaction = InstallmentTransactionService.GetInstallmentTransactionById(id);
                return Ok(InstallmentTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(InstallmentTransactionDTO obj)
        {
            try
            {
                var createdInstallmentTransaction = InstallmentTransactionService.CreateInstallmentTransaction(obj);
                return Ok(createdInstallmentTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<InstallmentTransactionDTO> InstallmentTransactions)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(InstallmentTransactionDTO obj)
        {
            try
            {
                var updatedInstallmentTransaction = InstallmentTransactionService.UpdateInstallmentTransaction(obj);
                return Ok(updatedInstallmentTransaction);
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
                var result = InstallmentTransactionService.DeleteInstallmentTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
