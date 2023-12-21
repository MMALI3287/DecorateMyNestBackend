using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ClientRepo
    {
        static ContextDb contextDb;

        public ClientRepo() { 
            contextDb = new ContextDb();
        }

        public static List<Client> GetClients()
        {
            return contextDb.Clients.ToList();
        }

        public static Client GetClientById(int id)
        {
            return contextDb.Clients.Find(id);
        }

        public static bool AddClient(Client client)
        {
            contextDb.Clients.Add(client);
            return contextDb.SaveChanges()>0;
        }

    }
}
