﻿using AutoMapper;
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

        //    public static bool IsTokenValid(string token)
        //    {
        //        var extTojen = DataAccessFactory.TokenData().Read(token);
        //        if (extTojen != null && extTojen.DeletedAt == null)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public static bool Logout(string token)
        //    {
        //        var extTojen = DataAccessFactory.TokenData().Read(token);
        //        extTojen.DeletedAt = DateTime.Now;
        //        if (DataAccessFactory.TokenData().Update(extTojen) != null)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
    }
}
