using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ChatListRepo : Repo, IRepo<ChatList, int, ChatList>
    {
        public ChatList Create(ChatList obj)
        {
            contextDb.ChatLists.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var chatList = Read(id);
            contextDb.ChatLists.Remove(chatList);
            return contextDb.SaveChanges() > 0;
        }

        public List<ChatList> Read()
        {
            return contextDb.ChatLists.ToList();
        }

        public ChatList Read(int id)
        {
            return contextDb.ChatLists.Find(id);
        }

        public ChatList Update(ChatList obj)
        {
            var extChatList = Read(obj.ChatId);
            contextDb.Entry(extChatList).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
