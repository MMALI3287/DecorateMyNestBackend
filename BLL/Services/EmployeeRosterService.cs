using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class EmployeeRosterService
    {
        public static List<EmployeeRosterDTO> GetEmployeeRosters()
        {
            var data = DataAccessFactory.EmployeeRosterData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeRoster, EmployeeRosterDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<EmployeeRosterDTO>>(data);
            return mapped;
        }

        public static EmployeeRosterDTO GetEmployeeRosterById(int id)
        {
            var data = DataAccessFactory.EmployeeRosterData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeRoster, EmployeeRosterDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<EmployeeRosterDTO>(data);
            return mapped;
        }

        public static EmployeeRosterDTO CreateEmployeeRoster(EmployeeRosterDTO EmployeeRoster)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeRoster, EmployeeRosterDTO>();
                c.CreateMap<EmployeeRosterDTO, EmployeeRoster>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<EmployeeRoster>(EmployeeRoster);
            var data = DataAccessFactory.EmployeeRosterData().Create(mapped);
            var mapped2 = mapper.Map<EmployeeRosterDTO>(data);
            return mapped2;
        }

        public static bool DeleteEmployeeRoster(int id)
        {
            return DataAccessFactory.EmployeeRosterData().Delete(id);
        }

        public static EmployeeRosterDTO UpdateEmployeeRoster(EmployeeRosterDTO EmployeeRoster)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeRoster, EmployeeRosterDTO>();
                c.CreateMap<EmployeeRosterDTO, EmployeeRoster>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<EmployeeRoster>(EmployeeRoster);
            var data = DataAccessFactory.EmployeeRosterData().Update(mapped);
            var mapped2 = mapper.Map<EmployeeRosterDTO>(data);
            return mapped2;
        }
    }
}
