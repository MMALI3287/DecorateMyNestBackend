using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/reservations")]
    public class ReservationController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Reservations = ReservationService.GetReservations();
                return Ok(Reservations);
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
                var Reservation = ReservationService.GetReservationById(id);
                return Ok(Reservation);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(ReservationDTO obj)
        {
            try
            {
                var createdReservation = ReservationService.CreateReservation(obj);
                return Ok(createdReservation);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<ReservationDTO> Reservations)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(ReservationDTO obj)
        {
            try
            {
                var updatedReservation = ReservationService.UpdateReservation(obj);
                return Ok(updatedReservation);
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
                var result = ReservationService.DeleteReservation(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
