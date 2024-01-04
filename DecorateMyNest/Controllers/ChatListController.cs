using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/chatLists")]
    public class ChatListController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var ChatLists = ChatListService.GetChatLists();
                return Ok(ChatLists);
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
                var ChatList = ChatListService.GetChatListById(id);
                return Ok(ChatList);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(ChatListDTO obj)
        {
            try
            {
                var createdChatList = ChatListService.CreateChatList(obj);
                return Ok(createdChatList);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<ChatListDTO> ChatLists)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(ChatListDTO obj)
        {
            try
            {
                var updatedChatList = ChatListService.UpdateChatList(obj);
                return Ok(updatedChatList);
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
                var result = ChatListService.DeleteChatList(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
