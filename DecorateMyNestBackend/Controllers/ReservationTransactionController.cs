using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/reservationTransactions")]
    public class ReservationTransactionController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var ReservationTransactions = ReservationTransactionService.GetReservationTransactions();
                return Ok(ReservationTransactions);
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
                var ReservationTransaction = ReservationTransactionService.GetReservationTransactionById(id);
                return Ok(ReservationTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(ReservationTransactionDTO obj)
        {
            try
            {
                var createdReservationTransaction = ReservationTransactionService.CreateReservationTransaction(obj);
                return Ok(createdReservationTransaction);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<ReservationTransactionDTO> ReservationTransactions)
        {
            try
            {
                var createdReservationTransactions = new List<ReservationTransactionDTO>();

                foreach (var ReservationTransaction in ReservationTransactions)
                {
                    var createdReservationTransaction = ReservationTransactionService.CreateReservationTransaction(ReservationTransaction);
                    createdReservationTransactions.Add(createdReservationTransaction);
                }

                return Ok(createdReservationTransactions);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(ReservationTransactionDTO obj)
        {
            try
            {
                var updatedReservationTransaction = ReservationTransactionService.UpdateReservationTransaction(obj);
                return Ok(updatedReservationTransaction);
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
                var result = ReservationTransactionService.DeleteReservationTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
