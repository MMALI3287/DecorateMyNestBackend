using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/chatLists")]
    public class ChatListController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/chatLists/")]
        public IActionResult Get()
        {
            try
            {
                var ChatLists = ChatListService.GetChatLists();
                return Ok(ChatLists);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/chatLists/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var ChatList = ChatListService.GetChatListById(id);
                return Ok(ChatList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/chatLists/")]
        public IActionResult Create(ChatListDTO obj)
        {
            try
            {
                var createdChatList = ChatListService.CreateChatList(obj);
                return Ok(createdChatList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/chatLists/create-multiple")]
        public IActionResult Create(List<ChatListDTO> ChatLists)
        {
            try
            {
                var createdChatLists = new List<ChatListDTO>();

                foreach (var ChatList in ChatLists)
                {
                    var createdChatList = ChatListService.CreateChatList(ChatList);
                    createdChatLists.Add(createdChatList);
                }

                return Ok(createdChatLists);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/chatLists/")]
        public IActionResult Update(ChatListDTO obj)
        {
            try
            {
                var updatedChatList = ChatListService.UpdateChatList(obj);
                return Ok(updatedChatList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/chatLists/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = ChatListService.DeleteChatList(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
