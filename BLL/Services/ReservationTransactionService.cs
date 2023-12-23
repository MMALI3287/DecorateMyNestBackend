using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ReservationTransactionService
    {
        public static List<ReservationTransactionDTO> GetReservationTransactions()
        {
            var data = DataAccessFactory.ReservationTransactionData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationTransaction, ReservationTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ReservationTransactionDTO>>(data);
            return mapped;
        }

        public static ReservationTransactionDTO GetReservationTransactionById(int id)
        {
            var data = DataAccessFactory.ReservationTransactionData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationTransaction, ReservationTransactionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ReservationTransactionDTO>(data);
            return mapped;
        }

        public static ReservationTransactionDTO CreateReservationTransaction(ReservationTransactionDTO ReservationTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationTransaction, ReservationTransactionDTO>();
                c.CreateMap<ReservationTransactionDTO, ReservationTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ReservationTransaction>(ReservationTransaction);
            var data = DataAccessFactory.ReservationTransactionData().Create(mapped);
            var mapped2 = mapper.Map<ReservationTransactionDTO>(data);
            return mapped2;
        }

        public static bool DeleteReservationTransaction(int id)
        {
            return DataAccessFactory.ReservationTransactionData().Delete(id);
        }

        public static ReservationTransactionDTO UpdateReservationTransaction(ReservationTransactionDTO ReservationTransaction)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationTransaction, ReservationTransactionDTO>();
                c.CreateMap<ReservationTransactionDTO, ReservationTransaction>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ReservationTransaction>(ReservationTransaction);
            var data = DataAccessFactory.ReservationTransactionData().Update(mapped);
            var mapped2 = mapper.Map<ReservationTransactionDTO>(data);
            return mapped2;
        }
    }
}
