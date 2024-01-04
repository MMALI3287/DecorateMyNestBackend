using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/messages")]
    public class MessageController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Messages = MessageService.GetMessages();
                return Ok(Messages);
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
                var Message = MessageService.GetMessageById(id);
                return Ok(Message);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(MessageDTO obj)
        {
            try
            {
                var createdMessage = MessageService.CreateMessage(obj);
                return Ok(createdMessage);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<MessageDTO> Messages)
        {
            try
            {
                var createdMessages = new List<MessageDTO>();

                foreach (var Message in Messages)
                {
                    var createdMessage = MessageService.CreateMessage(Message);
                    createdMessages.Add(createdMessage);
                }

                return Ok(createdMessages);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(MessageDTO obj)
        {
            try
            {
                var updatedMessage = MessageService.UpdateMessage(obj);
                return Ok(updatedMessage);
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
                var result = MessageService.DeleteMessage(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
