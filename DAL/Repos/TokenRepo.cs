using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        internal TokenRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var token = new TokenRepo(options);
        }

        public Token Create(Token obj)
        {
            contextDb.Tokens.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<Token> Read()
        {
            throw new System.NotImplementedException();
        }

        public Token Read(string id)
        {
            return contextDb.Tokens.FirstOrDefault(t => t.TokenKey == id);
        }

        public Token Update(Token obj)
        {
            var token = Read(obj.TokenKey);
            contextDb.Entry(token).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return token;
            return null;
        }
    }
}
