using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ArchivedProjectService
    {
        public static List<ArchivedProjectDTO> GetArchivedProjects()
        {
            var data = DataAccessFactory.ArchivedProjectData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ArchivedProject, ArchivedProjectDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ArchivedProjectDTO>>(data);
            return mapped;
        }

        public static ArchivedProjectDTO GetArchivedProjectById(int id)
        {
            var data = DataAccessFactory.ArchivedProjectData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ArchivedProject, ArchivedProjectDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ArchivedProjectDTO>(data);
            return mapped;
        }

        public static ArchivedProjectDTO CreateArchivedProject(ArchivedProjectDTO archivedProject)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ArchivedProject, ArchivedProjectDTO>();
                c.CreateMap<ArchivedProjectDTO, ArchivedProject>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ArchivedProject>(archivedProject);
            var data = DataAccessFactory.ArchivedProjectData().Create(mapped);
            var mapped2 = mapper.Map<ArchivedProjectDTO>(data);
            return mapped2;
        }

        public static bool DeleteArchivedProject(int id)
        {
            return DataAccessFactory.ArchivedProjectData().Delete(id);
        }

        public static ArchivedProjectDTO UpdateArchivedProject(ArchivedProjectDTO archivedProject)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ArchivedProject, ArchivedProjectDTO>();
                c.CreateMap<ArchivedProjectDTO, ArchivedProject>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ArchivedProject>(archivedProject);
            var data = DataAccessFactory.ArchivedProjectData().Update(mapped);
            var mapped2 = mapper.Map<ArchivedProjectDTO>(data);
            return mapped2;
        }
    }
}
