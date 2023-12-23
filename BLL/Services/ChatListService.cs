using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ChatListService
    {
        public static List<ChatListDTO> GetChatLists()
        {
            var data = DataAccessFactory.ChatListData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ChatList, ChatListDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ChatListDTO>>(data);
            return mapped;
        }

        public static ChatListDTO GetChatListById(int id)
        {
            var data = DataAccessFactory.ChatListData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ChatList, ChatListDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ChatListDTO>(data);
            return mapped;
        }

        public static ChatListDTO CreateChatList(ChatListDTO ChatList)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ChatList, ChatListDTO>();
                c.CreateMap<ChatListDTO, ChatList>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ChatList>(ChatList);
            var data = DataAccessFactory.ChatListData().Create(mapped);
            var mapped2 = mapper.Map<ChatListDTO>(data);
            return mapped2;
        }

        public static bool DeleteChatList(int id)
        {
            return DataAccessFactory.ChatListData().Delete(id);
        }

        public static ChatListDTO UpdateChatList(ChatListDTO ChatList)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ChatList, ChatListDTO>();
                c.CreateMap<ChatListDTO, ChatList>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ChatList>(ChatList);
            var data = DataAccessFactory.ChatListData().Update(mapped);
            var mapped2 = mapper.Map<ChatListDTO>(data);
            return mapped2;
        }
    }
}
