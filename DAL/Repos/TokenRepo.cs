using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>, IReadByValue<Token, string, bool>
    {
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
            return contextDb.Tokens.ToList();
        }

        public Token Read(string token)
        {
            return (from t in contextDb.Tokens where t.TokenKey == token && t.DeletedAt == null && t.ExpiresAt > DateTime.Now select t).SingleOrDefault();
        }

        public Token ReadByUser(string username)
        {
            return contextDb.Tokens.SingleOrDefault(t => t.UserId == username);
        }

        public Token ReadByValue(string value)
        {
            return contextDb.Tokens.SingleOrDefault(t => t.TokenKey == value);
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
