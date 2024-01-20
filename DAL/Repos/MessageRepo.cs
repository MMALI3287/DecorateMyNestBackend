using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repos
{
    internal class MessageRepo : Repo, IRepo<Message, int, Message>
    {
        internal MessageRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var message = new MessageRepo(options);
        }

        public Message Create(Message obj)
        {
            contextDb.Messages.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var message = Read(id);
            contextDb.Messages.Remove(message);
            return contextDb.SaveChanges() > 0;
        }

        public System.Collections.Generic.List<Message> Read()
        {
            return contextDb.Messages.ToList();
        }

        public Message Read(int id)
        {
            return contextDb.Messages.Find(id);
        }

        public Message Update(Message obj)
        {
            var extMessage = Read(obj.ChatId);
            contextDb.Entry(extMessage).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
