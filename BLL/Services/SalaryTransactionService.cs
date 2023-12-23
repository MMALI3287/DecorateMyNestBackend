using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class SalaryTransactionService
    {
        public static List<SalaryTransactionDTO> GetSalaryTransactions()
        {
            var data = DataAccessFactory.SalaryTransactionData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryTransaction, SalaryTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<SalaryTransactionDTO>>(data);
            return mapped;
        }

        public static SalaryTransactionDTO GetSalaryTransactionById(int id)
        {
            var data = DataAccessFactory.SalaryTransactionData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryTransaction, SalaryTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<SalaryTransactionDTO>(data);
            return mapped;
        }

        public static SalaryTransactionDTO CreateSalaryTransaction(SalaryTransactionDTO SalaryTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryTransaction, SalaryTransactionDTO>();
                c.CreateMap<SalaryTransactionDTO, SalaryTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<SalaryTransaction>(SalaryTransaction);
            var data = DataAccessFactory.SalaryTransactionData().Create(mapped);
            var mapped2 = mapper.Map<SalaryTransactionDTO>(data);
            return mapped2;
        }

        public static bool DeleteSalaryTransaction(int id)
        {
            return DataAccessFactory.SalaryTransactionData().Delete(id);
        }

        public static SalaryTransactionDTO UpdateSalaryTransaction(SalaryTransactionDTO SalaryTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryTransaction, SalaryTransactionDTO>();
                c.CreateMap<SalaryTransactionDTO, SalaryTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<SalaryTransaction>(SalaryTransaction);
            var data = DataAccessFactory.SalaryTransactionData().Update(mapped);
            var mapped2 = mapper.Map<SalaryTransactionDTO>(data);
            return mapped2;
        }
    }
}
