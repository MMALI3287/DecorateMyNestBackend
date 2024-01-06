using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/notifications")]
    public class NotificationController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Notifications = NotificationService.GetNotifications();
                return Ok(Notifications);
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
                var Notification = NotificationService.GetNotificationById(id);
                return Ok(Notification);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(NotificationDTO obj)
        {
            try
            {
                var createdNotification = NotificationService.CreateNotification(obj);
                return Ok(createdNotification);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<NotificationDTO> Notifications)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(NotificationDTO obj)
        {
            try
            {
                var updatedNotification = NotificationService.UpdateNotification(obj);
                return Ok(updatedNotification);
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
                var result = NotificationService.DeleteNotification(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
