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
            //var res = DataAccessFactory.AuthData().Authenticate(username, password);
            var res = true;
            if (res)
            {
                var token = new Token();
                token.UserId = username;
                token.CreatedAt = DateTime.Now;
                token.ExpiresAt = DateTime.Now.AddMinutes(5);
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
    }
}
