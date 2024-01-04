// Ignore Spelling: Admins
// Ignore Spelling: Admin
// Ignore Spelling: BLL

using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> GetAdmins()
        {
            var data = DataAccessFactory.AdminData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }

        public static AdminDTO GetAdminById(int id)
        {
            var data = DataAccessFactory.AdminData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }

        public static AdminDTO CreateAdmin(AdminDTO admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Admin>(admin);
            var data = DataAccessFactory.AdminData().Create(mapped);
            var mapped2 = mapper.Map<AdminDTO>(data);
            return mapped2;
        }

        public static bool DeleteAdmin(int id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }

        public static AdminDTO UpdateAdmin(AdminDTO admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Admin>(admin);
            var data = DataAccessFactory.AdminData().Update(mapped);
            var mapped2 = mapper.Map<AdminDTO>(data);
            return mapped2;
        }
    }
}
