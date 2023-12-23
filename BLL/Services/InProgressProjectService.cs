using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class InProgressProjectService
    {
        public static List<InProgressProjectDTO> GetInProgressProjects()
        {
            var data = DataAccessFactory.InProgressProjectData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InProgressProject, InProgressProjectDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<InProgressProjectDTO>>(data);
            return mapped;
        }

        public static InProgressProjectDTO GetInProgressProjectById(int id)
        {
            var data = DataAccessFactory.InProgressProjectData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InProgressProject, InProgressProjectDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<InProgressProjectDTO>(data);
            return mapped;
        }

        public static InProgressProjectDTO CreateInProgressProject(InProgressProjectDTO InProgressProject)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InProgressProject, InProgressProjectDTO>();
                c.CreateMap<InProgressProjectDTO, InProgressProject>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<InProgressProject>(InProgressProject);
            var data = DataAccessFactory.InProgressProjectData().Create(mapped);
            var mapped2 = mapper.Map<InProgressProjectDTO>(data);
            return mapped2;
        }

        public static bool DeleteInProgressProject(int id)
        {
            return DataAccessFactory.InProgressProjectData().Delete(id);
        }

        public static InProgressProjectDTO UpdateInProgressProject(InProgressProjectDTO InProgressProject)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InProgressProject, InProgressProjectDTO>();
                c.CreateMap<InProgressProjectDTO, InProgressProject>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<InProgressProject>(InProgressProject);
            var data = DataAccessFactory.InProgressProjectData().Update(mapped);
            var mapped2 = mapper.Map<InProgressProjectDTO>(data);
            return mapped2;
        }
    }
}
