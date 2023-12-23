using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class NotificationService
    {
        public static List<NotificationDTO> GetNotifications()
        {
            var data = DataAccessFactory.NotificationData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notification, NotificationDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<NotificationDTO>>(data);
            return mapped;
        }

        public static NotificationDTO GetNotificationById(int id)
        {
            var data = DataAccessFactory.NotificationData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notification, NotificationDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<NotificationDTO>(data);
            return mapped;
        }

        public static NotificationDTO CreateNotification(NotificationDTO Notification)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notification, NotificationDTO>();
                c.CreateMap<NotificationDTO, Notification>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Notification>(Notification);
            var data = DataAccessFactory.NotificationData().Create(mapped);
            var mapped2 = mapper.Map<NotificationDTO>(data);
            return mapped2;
        }

        public static bool DeleteNotification(int id)
        {
            return DataAccessFactory.NotificationData().Delete(id);
        }

        public static NotificationDTO UpdateNotification(NotificationDTO Notification)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notification, NotificationDTO>();
                c.CreateMap<NotificationDTO, Notification>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Notification>(Notification);
            var data = DataAccessFactory.NotificationData().Update(mapped);
            var mapped2 = mapper.Map<NotificationDTO>(data);
            return mapped2;
        }
    }
}

