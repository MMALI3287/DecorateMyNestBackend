using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/messages/")]
        public IActionResult Get()
        {
            try
            {
                var Messages = MessageService.GetMessages();
                return Ok(Messages);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/messages/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Message = MessageService.GetMessageById(id);
                return Ok(Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/messages/")]
        public IActionResult Create(MessageDTO obj)
        {
            try
            {
                var createdMessage = MessageService.CreateMessage(obj);
                return Ok(createdMessage);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/messages/create-multiple")]
        public IActionResult Create(List<MessageDTO> Messages)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/messages/")]
        public IActionResult Update(MessageDTO obj)
        {
            try
            {
                var updatedMessage = MessageService.UpdateMessage(obj);
                return Ok(updatedMessage);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/messages/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = MessageService.DeleteMessage(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
