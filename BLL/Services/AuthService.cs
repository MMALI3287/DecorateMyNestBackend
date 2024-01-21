using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var res = DataAccessFactory.AuthData().Authenticate(username, password);
            if (res)
            {
                var token = new Token();
                token.UserId = username;
                token.CreatedAt = DateTime.UtcNow;
                token.TokenKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Create(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    var mapped = mapper.Map<TokenDTO>(ret);
                    return mapped;
                }
            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            var extToken = DataAccessFactory.TokenData().Read(token);
            if (extToken != null && extToken.ExpiresAt > DateTime.Now && extToken.DeletedAt == null)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteToken(string token)
        {
            return DataAccessFactory.TokenData().Delete(token);
        }

        public static TokenDTO UserExist(string username)
        {
            var ret = DataAccessFactory.AuthData().HasExtToken(username);
            if (ret != null)
            {
                var cfg = new MapperConfiguration(c =>
                {
                    c.CreateMap<Token, TokenDTO>();
                });
                var mapper = new Mapper(cfg);
                var mapped = mapper.Map<TokenDTO>(ret);
                return mapped;
            }
            return null;
        }

        public static bool Logout(string username)
        {
            var extToken = DataAccessFactory.AuthData().HasExtToken(username);
            if (extToken != null)
            {
                if (extToken.DeletedAt == null)
                {
                    extToken.DeletedAt = DateTime.Now;

                    if (DataAccessFactory.TokenData().Update(extToken) != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static TokenDTO GoogleTokenCreate(string username)
        {
            var token = new Token();
            token.UserId = username;
            token.CreatedAt = DateTime.UtcNow;
            token.TokenKey = Guid.NewGuid().ToString();
            var ret = DataAccessFactory.TokenData().Create(token);
            if (ret != null)
            {
                var cfg = new MapperConfiguration(c =>
                {
                    c.CreateMap<Token, TokenDTO>();
                });
                var mapper = new Mapper(cfg);
                var mapped = mapper.Map<TokenDTO>(ret);
                return mapped;
            }
            return null;
        }
    }
}
