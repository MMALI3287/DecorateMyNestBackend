using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/appointments/")]
        public IActionResult Get()
        {
            try
            {
                var Appointments = AppointmentService.GetAppointments();
                return Ok(Appointments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/appointments/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Appointment = AppointmentService.GetAppointmentById(id);
                return Ok(Appointment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/appointments/")]
        public IActionResult Create(AppointmentDTO obj)
        {
            try
            {
                var createdAppointment = AppointmentService.CreateAppointment(obj);
                return Ok(createdAppointment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/appointments/create-multiple")]
        public IActionResult Create(List<AppointmentDTO> Appointments)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/appointments/")]
        public IActionResult Update(AppointmentDTO obj)
        {
            try
            {
                var updatedAppointment = AppointmentService.UpdateAppointment(obj);
                return Ok(updatedAppointment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/appointments/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = AppointmentService.DeleteAppointment(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
