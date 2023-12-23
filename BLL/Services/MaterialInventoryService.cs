using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class MaterialInventoryService
    {
        public static List<MaterialInventoryDTO> GetMaterialInventorys()
        {
            var data = DataAccessFactory.MaterialInventoryData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialInventory, MaterialInventoryDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<MaterialInventoryDTO>>(data);
            return mapped;
        }

        public static MaterialInventoryDTO GetMaterialInventoryById(int id)
        {
            var data = DataAccessFactory.MaterialInventoryData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialInventory, MaterialInventoryDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MaterialInventoryDTO>(data);
            return mapped;
        }

        public static MaterialInventoryDTO CreateMaterialInventory(MaterialInventoryDTO MaterialInventory)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialInventory, MaterialInventoryDTO>();
                c.CreateMap<MaterialInventoryDTO, MaterialInventory>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MaterialInventory>(MaterialInventory);
            var data = DataAccessFactory.MaterialInventoryData().Create(mapped);
            var mapped2 = mapper.Map<MaterialInventoryDTO>(data);
            return mapped2;
        }

        public static bool DeleteMaterialInventory(int id)
        {
            return DataAccessFactory.MaterialInventoryData().Delete(id);
        }

        public static MaterialInventoryDTO UpdateMaterialInventory(MaterialInventoryDTO MaterialInventory)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialInventory, MaterialInventoryDTO>();
                c.CreateMap<MaterialInventoryDTO, MaterialInventory>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MaterialInventory>(MaterialInventory);
            var data = DataAccessFactory.MaterialInventoryData().Update(mapped);
            var mapped2 = mapper.Map<MaterialInventoryDTO>(data);
            return mapped2;
        }
    }
}
