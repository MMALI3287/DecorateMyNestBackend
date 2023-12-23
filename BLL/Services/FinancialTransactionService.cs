using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class FinancialTransactionService
    {
        public static List<FinancialTransactionDTO> GetFinancialTransactions()
        {
            var data = DataAccessFactory.FinancialTransactionData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FinancialTransaction, FinancialTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<FinancialTransactionDTO>>(data);
            return mapped;
        }

        public static FinancialTransactionDTO GetFinancialTransactionById(int id)
        {
            var data = DataAccessFactory.FinancialTransactionData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FinancialTransaction, FinancialTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<FinancialTransactionDTO>(data);
            return mapped;
        }

        public static FinancialTransactionDTO CreateFinancialTransaction(FinancialTransactionDTO FinancialTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FinancialTransaction, FinancialTransactionDTO>();
                c.CreateMap<FinancialTransactionDTO, FinancialTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<FinancialTransaction>(FinancialTransaction);
            var data = DataAccessFactory.FinancialTransactionData().Create(mapped);
            var mapped2 = mapper.Map<FinancialTransactionDTO>(data);
            return mapped2;
        }

        public static bool DeleteFinancialTransaction(int id)
        {
            return DataAccessFactory.FinancialTransactionData().Delete(id);
        }

        public static FinancialTransactionDTO UpdateFinancialTransaction(FinancialTransactionDTO FinancialTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FinancialTransaction, FinancialTransactionDTO>();
                c.CreateMap<FinancialTransactionDTO, FinancialTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<FinancialTransaction>(FinancialTransaction);
            var data = DataAccessFactory.FinancialTransactionData().Update(mapped);
            var mapped2 = mapper.Map<FinancialTransactionDTO>(data);
            return mapped2;
        }
    }
}
