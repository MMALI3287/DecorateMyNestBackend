using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/notifications/")]
        public IActionResult Get()
        {
            try
            {
                var Notifications = NotificationService.GetNotifications();
                return Ok(Notifications);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/notifications/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Notification = NotificationService.GetNotificationById(id);
                return Ok(Notification);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/notifications/")]
        public IActionResult Create(NotificationDTO obj)
        {
            try
            {
                var createdNotification = NotificationService.CreateNotification(obj);
                return Ok(createdNotification);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/notifications/create-multiple")]
        public IActionResult Create(List<NotificationDTO> Notifications)
        {
            try
            {
                var createdNotifications = new List<NotificationDTO>();

                foreach (var Notification in Notifications)
                {
                    var createdNotification = NotificationService.CreateNotification(Notification);
                    createdNotifications.Add(createdNotification);
                }

                return Ok(createdNotifications);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/notifications/")]
        public IActionResult Update(NotificationDTO obj)
        {
            try
            {
                var updatedNotification = NotificationService.UpdateNotification(obj);
                return Ok(updatedNotification);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/notifications/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = NotificationService.DeleteNotification(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
