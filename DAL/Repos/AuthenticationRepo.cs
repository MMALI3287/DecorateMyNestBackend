using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class AuthenticationRepo : Repo, IRepo<Authentication, int, Authentication>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = contextDb.Authentications.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (data != null) return true;
            return false;
        }

        public Authentication Create(Authentication obj)
        {
            contextDb.Authentications.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var authentication = Read(id);
            contextDb.Authentications.Remove(authentication);
            return contextDb.SaveChanges() > 0;
        }

        public List<Authentication> Read()
        {
            return contextDb.Authentications.ToList();
        }

        public Authentication Read(int id)
        {
            return contextDb.Authentications.Find(id);
        }

        public Authentication Update(Authentication obj)
        {
            var extAuthentication = Read(obj.AuthId);
            contextDb.Entry(extAuthentication).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}