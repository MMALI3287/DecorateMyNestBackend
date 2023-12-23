using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class MaterialTransactionService
    {
        public static List<MaterialTransactionDTO> GetMaterialTransactions()
        {
            var data = DataAccessFactory.MaterialTransactionData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialTransaction, MaterialTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<MaterialTransactionDTO>>(data);
            return mapped;
        }

        public static MaterialTransactionDTO GetMaterialTransactionById(int id)
        {
            var data = DataAccessFactory.MaterialTransactionData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialTransaction, MaterialTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MaterialTransactionDTO>(data);
            return mapped;
        }

        public static MaterialTransactionDTO CreateMaterialTransaction(MaterialTransactionDTO MaterialTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialTransaction, MaterialTransactionDTO>();
                c.CreateMap<MaterialTransactionDTO, MaterialTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MaterialTransaction>(MaterialTransaction);
            var data = DataAccessFactory.MaterialTransactionData().Create(mapped);
            var mapped2 = mapper.Map<MaterialTransactionDTO>(data);
            return mapped2;
        }

        public static bool DeleteMaterialTransaction(int id)
        {
            return DataAccessFactory.MaterialTransactionData().Delete(id);
        }

        public static MaterialTransactionDTO UpdateMaterialTransaction(MaterialTransactionDTO MaterialTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MaterialTransaction, MaterialTransactionDTO>();
                c.CreateMap<MaterialTransactionDTO, MaterialTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<MaterialTransaction>(MaterialTransaction);
            var data = DataAccessFactory.MaterialTransactionData().Update(mapped);
            var mapped2 = mapper.Map<MaterialTransactionDTO>(data);
            return mapped2;
        }
    }
}
