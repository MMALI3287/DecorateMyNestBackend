using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/reservationTransactions")]
    public class ReservationTransactionController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/reservationTransactions/")]
        public IActionResult Get()
        {
            try
            {
                var ReservationTransactions = ReservationTransactionService.GetReservationTransactions();
                return Ok(ReservationTransactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/reservationTransactions/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var ReservationTransaction = ReservationTransactionService.GetReservationTransactionById(id);
                return Ok(ReservationTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/reservationTransactions/")]
        public IActionResult Create(ReservationTransactionDTO obj)
        {
            try
            {
                var createdReservationTransaction = ReservationTransactionService.CreateReservationTransaction(obj);
                return Ok(createdReservationTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/reservationTransactions/create-multiple")]
        public IActionResult Create(List<ReservationTransactionDTO> ReservationTransactions)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/reservationTransactions/")]
        public IActionResult Update(ReservationTransactionDTO obj)
        {
            try
            {
                var updatedReservationTransaction = ReservationTransactionService.UpdateReservationTransaction(obj);
                return Ok(updatedReservationTransaction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/reservationTransactions/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = ReservationTransactionService.DeleteReservationTransaction(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
