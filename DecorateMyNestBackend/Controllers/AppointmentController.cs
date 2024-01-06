using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/appointments")]
    public class AppointmentController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Appointments = AppointmentService.GetAppointments();
                return Ok(Appointments);
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
                var Appointment = AppointmentService.GetAppointmentById(id);
                return Ok(Appointment);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(AppointmentDTO obj)
        {
            try
            {
                var createdAppointment = AppointmentService.CreateAppointment(obj);
                return Ok(createdAppointment);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<AppointmentDTO> Appointments)
        {
            try
            {
                var createdAppointments = new List<AppointmentDTO>();

                foreach (var Appointment in Appointments)
                {
                    var createdAppointment = AppointmentService.CreateAppointment(Appointment);
                    createdAppointments.Add(createdAppointment);
                }

                return Ok(createdAppointments);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(AppointmentDTO obj)
        {
            try
            {
                var updatedAppointment = AppointmentService.UpdateAppointment(obj);
                return Ok(updatedAppointment);
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
                var result = AppointmentService.DeleteAppointment(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
