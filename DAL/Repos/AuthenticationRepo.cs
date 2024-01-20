using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class AuthenticationRepo : Repo, IRepo<Authentication, int, Authentication>, IAuth<bool>, IRegi<Authentication, string>
    {
        internal AuthenticationRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var authentication = new AuthenticationRepo(options);
        }

        public bool Authenticate(string username, string password)
        {
            var data = (from d in contextDb.Authentications where d.UserName.Equals(username) && d.Password.Equals(password) select d).SingleOrDefault();
            if (data != null) return true;
            return false;
        }

        //public Token HasExtToken(string Username)
        //{
        //    var extToken = (from t in contextDb.Tokens where t.UserId.Equals(Username) && t.DeletedAt == null select t).SingleOrDefault();
        //    if (extToken != null) return extToken;
        //    return null;
        //}

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

        public Authentication Read(string id)
        {
            var extreg = (from r in contextDb.Authentications where r.UserName.Equals(id) select r).SingleOrDefault();
            return extreg;
        }

        //Token IAuth<Token>.Authenticate(string username, string password)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}