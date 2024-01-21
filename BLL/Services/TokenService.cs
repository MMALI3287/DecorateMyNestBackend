using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TokenService
    {
        public static List<TokenDTO> GetTokens()
        {
            var data = DataAccessFactory.TokenData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<TokenDTO>>(data);
            return mapped;
        }



        public static TokenDTO CreateToken(TokenDTO Token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenDTO>();
                c.CreateMap<TokenDTO, Token>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Token>(Token);
            var data = DataAccessFactory.TokenData().Create(mapped);
            var mapped2 = mapper.Map<TokenDTO>(data);
            return mapped2;
        }


        public static TokenDTO UpdateToken(TokenDTO Token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenDTO>();
                c.CreateMap<TokenDTO, Token>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Token>(Token);
            var data = DataAccessFactory.TokenData().Update(mapped);
            var mapped2 = mapper.Map<TokenDTO>(data);
            return mapped2;
        }

    }
}
