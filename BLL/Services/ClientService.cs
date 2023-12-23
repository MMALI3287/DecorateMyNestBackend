using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ClientService
    {
        public static List<ClientDTO> GetClients()
        {
            var data = DataAccessFactory.ClientData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Client, ClientDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ClientDTO>>(data);
            return mapped;
        }

        public static ClientDTO GetClientById(int id)
        {
            var data = DataAccessFactory.ClientData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Client, ClientDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ClientDTO>(data);
            return mapped;
        }

        public static ClientDTO Create(ClientDTO client)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Client, ClientDTO>();
                c.CreateMap<ClientDTO, Client>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Client>(client);
            var data = DataAccessFactory.ClientData().Create(mapped);
            var mapped2 = mapper.Map<ClientDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ClientData().Delete(id);
        }

        public static ClientDTO Update(ClientDTO client)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Client, ClientDTO>();
                c.CreateMap<ClientDTO, Client>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Client>(client);
            var data = DataAccessFactory.ClientData().Update(mapped);
            var mapped2 = mapper.Map<ClientDTO>(data);
            return mapped2;
        }

        //public static List<Client> Get10()
        //{
        //    var data =from e in ClientRepo.GetClients()
        //              where e.ClientId<11
        //              select e;
        //    return data.ToList();
        //}
    }
}