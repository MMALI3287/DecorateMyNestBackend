using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class NotificationRepo : Repo, IRepo<Notification, int, Notification>
    {
        public Notification Create(Notification obj)
        {
            contextDb.Notifications.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var notification = Read(id);
            contextDb.Notifications.Remove(notification);
            return contextDb.SaveChanges() > 0;
        }

        public List<Notification> Read()
        {
            return contextDb.Notifications.ToList();
        }

        public Notification Read(int id)
        {
            return contextDb.Notifications.Find(id);
        }

        public Notification Update(Notification obj)
        {
            var extNotification = Read(obj.NotificationId);
            contextDb.Entry(extNotification).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
