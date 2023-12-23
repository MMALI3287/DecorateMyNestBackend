using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class InstallmentTransactionService
    {
        public static List<InstallmentTransactionDTO> GetInstallmentTransactions()
        {
            var data = DataAccessFactory.InstallmentTransactionData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InstallmentTransaction, InstallmentTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<InstallmentTransactionDTO>>(data);
            return mapped;
        }

        public static InstallmentTransactionDTO GetInstallmentTransactionById(int id)
        {
            var data = DataAccessFactory.InstallmentTransactionData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InstallmentTransaction, InstallmentTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<InstallmentTransactionDTO>(data);
            return mapped;
        }

        public static InstallmentTransactionDTO CreateInstallmentTransaction(InstallmentTransactionDTO InstallmentTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InstallmentTransaction, InstallmentTransactionDTO>();
                c.CreateMap<InstallmentTransactionDTO, InstallmentTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<InstallmentTransaction>(InstallmentTransaction);
            var data = DataAccessFactory.InstallmentTransactionData().Create(mapped);
            var mapped2 = mapper.Map<InstallmentTransactionDTO>(data);
            return mapped2;
        }

        public static bool DeleteInstallmentTransaction(int id)
        {
            return DataAccessFactory.InstallmentTransactionData().Delete(id);
        }

        public static InstallmentTransactionDTO UpdateInstallmentTransaction(InstallmentTransactionDTO InstallmentTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InstallmentTransaction, InstallmentTransactionDTO>();
                c.CreateMap<InstallmentTransactionDTO, InstallmentTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<InstallmentTransaction>(InstallmentTransaction);
            var data = DataAccessFactory.InstallmentTransactionData().Update(mapped);
            var mapped2 = mapper.Map<InstallmentTransactionDTO>(data);
            return mapped2;
        }
    }
}

