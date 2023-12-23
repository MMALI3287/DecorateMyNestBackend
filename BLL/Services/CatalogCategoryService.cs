using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class CatalogCategoryService
    {
        public static List<CatalogCategoryDTO> GetCatalogCategorys()
        {
            var data = DataAccessFactory.CatalogCategoryData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CatalogCategory, CatalogCategoryDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<CatalogCategoryDTO>>(data);
            return mapped;
        }

        public static CatalogCategoryDTO GetCatalogCategoryById(int id)
        {
            var data = DataAccessFactory.CatalogCategoryData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CatalogCategory, CatalogCategoryDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<CatalogCategoryDTO>(data);
            return mapped;
        }

        public static CatalogCategoryDTO CreateCatalogCategory(CatalogCategoryDTO CatalogCategory)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CatalogCategory, CatalogCategoryDTO>();
                c.CreateMap<CatalogCategoryDTO, CatalogCategory>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<CatalogCategory>(CatalogCategory);
            var data = DataAccessFactory.CatalogCategoryData().Create(mapped);
            var mapped2 = mapper.Map<CatalogCategoryDTO>(data);
            return mapped2;
        }

        public static bool DeleteCatalogCategory(int id)
        {
            return DataAccessFactory.CatalogCategoryData().Delete(id);
        }

        public static CatalogCategoryDTO UpdateCatalogCategory(CatalogCategoryDTO CatalogCategory)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CatalogCategory, CatalogCategoryDTO>();
                c.CreateMap<CatalogCategoryDTO, CatalogCategory>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<CatalogCategory>(CatalogCategory);
            var data = DataAccessFactory.CatalogCategoryData().Update(mapped);
            var mapped2 = mapper.Map<CatalogCategoryDTO>(data);
            return mapped2;
        }
    }
}
