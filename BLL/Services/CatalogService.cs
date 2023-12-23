using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class CatalogService
    {
        public static List<CatalogDTO> GetCatalogs()
        {
            var data = DataAccessFactory.CatalogData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Catalog, CatalogDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<CatalogDTO>>(data);
            return mapped;
        }

        public static CatalogDTO GetCatalogById(int id)
        {
            var data = DataAccessFactory.CatalogData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Catalog, CatalogDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<CatalogDTO>(data);
            return mapped;
        }

        public static CatalogDTO CreateCatalog(CatalogDTO Catalog)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Catalog, CatalogDTO>();
                c.CreateMap<CatalogDTO, Catalog>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Catalog>(Catalog);
            var data = DataAccessFactory.CatalogData().Create(mapped);
            var mapped2 = mapper.Map<CatalogDTO>(data);
            return mapped2;
        }

        public static bool DeleteCatalog(int id)
        {
            return DataAccessFactory.CatalogData().Delete(id);
        }

        public static CatalogDTO UpdateCatalog(CatalogDTO Catalog)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Catalog, CatalogDTO>();
                c.CreateMap<CatalogDTO, Catalog>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Catalog>(Catalog);
            var data = DataAccessFactory.CatalogData().Update(mapped);
            var mapped2 = mapper.Map<CatalogDTO>(data);
            return mapped2;
        }
    }
}
