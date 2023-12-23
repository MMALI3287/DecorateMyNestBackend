using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class MessageService
    {
        public static List<MessageDTO> GetMessages()
        {
            var data = DataAccessFactory.MessageData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<MessageDTO>>(data);
            return mapped;
        }

        public static MessageDTO GetMessageById(int id)
        {
            var data = DataAccessFactory.MessageData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MessageDTO>(data);
            return mapped;
        }

        public static MessageDTO CreateMessage(MessageDTO Message)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageDTO>();
                c.CreateMap<MessageDTO, Message>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Message>(Message);
            var data = DataAccessFactory.MessageData().Create(mapped);
            var mapped2 = mapper.Map<MessageDTO>(data);
            return mapped2;
        }

        public static bool DeleteMessage(int id)
        {
            return DataAccessFactory.MessageData().Delete(id);
        }

        public static MessageDTO UpdateMessage(MessageDTO Message)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageDTO>();
                c.CreateMap<MessageDTO, Message>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Message>(Message);
            var data = DataAccessFactory.MessageData().Update(mapped);
            var mapped2 = mapper.Map<MessageDTO>(data);
            return mapped2;
        }
    }
}
