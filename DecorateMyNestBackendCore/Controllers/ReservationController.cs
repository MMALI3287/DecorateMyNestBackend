using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/reservations")]
    public class ReservationController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/reservations/")]
        public IActionResult Get()
        {
            try
            {
                var Reservations = ReservationService.GetReservations();
                return Ok(Reservations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/reservations/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Reservation = ReservationService.GetReservationById(id);
                return Ok(Reservation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/reservations/")]
        public IActionResult Create(ReservationDTO obj)
        {
            try
            {
                var createdReservation = ReservationService.CreateReservation(obj);
                return Ok(createdReservation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/reservations/create-multiple")]
        public IActionResult Create(List<ReservationDTO> Reservations)
        {
            try
            {
                var createdReservations = new List<ReservationDTO>();

                foreach (var Reservation in Reservations)
                {
                    var createdReservation = ReservationService.CreateReservation(Reservation);
                    createdReservations.Add(createdReservation);
                }

                return Ok(createdReservations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/reservations/")]
        public IActionResult Update(ReservationDTO obj)
        {
            try
            {
                var updatedReservation = ReservationService.UpdateReservation(obj);
                return Ok(updatedReservation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/reservations/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = ReservationService.DeleteReservation(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
