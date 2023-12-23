using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ClientRepo : Repo, IRepo<Client, int, Client>
    {
        public Client Create(Client obj)
        {
            contextDb.Clients.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var client = Read(id);
            contextDb.Clients.Remove(client);
            return contextDb.SaveChanges() > 0;
        }

        public List<Client> Read()
        {
            return contextDb.Clients.ToList();
        }

        public Client Read(int id)
        {
            return contextDb.Clients.Find(id);
        }

        public Client Update(Client obj)
        {
            var extClient = Read(obj.ClientId);
            contextDb.Entry(extClient).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}