using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AuthenticationService
    {
        public static List<AuthenticationDTO> GetAuthentications()
        {
            var data = DataAccessFactory.AuthenticationData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Authentication, AuthenticationDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<AuthenticationDTO>>(data);
            return mapped;
        }

        public static AuthenticationDTO GetAuthenticationById(int id)
        {
            var data = DataAccessFactory.AuthenticationData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Authentication, AuthenticationDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<AuthenticationDTO>(data);
            return mapped;
        }

        public static AuthenticationDTO CreateAuthentication(AuthenticationDTO Authentication)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Authentication, AuthenticationDTO>();
                c.CreateMap<AuthenticationDTO, Authentication>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Authentication>(Authentication);
            var data = DataAccessFactory.AuthenticationData().Create(mapped);
            var mapped2 = mapper.Map<AuthenticationDTO>(data);
            return mapped2;
        }

        public static bool DeleteAuthentication(int id)
        {
            return DataAccessFactory.AuthenticationData().Delete(id);
        }

        public static AuthenticationDTO UpdateAuthentication(AuthenticationDTO Authentication)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Authentication, AuthenticationDTO>();
                c.CreateMap<AuthenticationDTO, Authentication>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Authentication>(Authentication);
            var data = DataAccessFactory.AuthenticationData().Update(mapped);
            var mapped2 = mapper.Map<AuthenticationDTO>(data);
            return mapped2;
        }
    }
}
