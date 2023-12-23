using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ReservationService
    {
        public static List<ReservationDTO> GetReservations()
        {
            var data = DataAccessFactory.ReservationData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ReservationDTO>>(data);
            return mapped;
        }

        public static ReservationDTO GetReservationById(int id)
        {
            var data = DataAccessFactory.ReservationData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ReservationDTO>(data);
            return mapped;
        }

        public static ReservationDTO CreateReservation(ReservationDTO Reservation)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
                c.CreateMap<ReservationDTO, Reservation>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Reservation>(Reservation);
            var data = DataAccessFactory.ReservationData().Create(mapped);
            var mapped2 = mapper.Map<ReservationDTO>(data);
            return mapped2;
        }

        public static bool DeleteReservation(int id)
        {
            return DataAccessFactory.ReservationData().Delete(id);
        }

        public static ReservationDTO UpdateReservation(ReservationDTO Reservation)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
                c.CreateMap<ReservationDTO, Reservation>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Reservation>(Reservation);
            var data = DataAccessFactory.ReservationData().Update(mapped);
            var mapped2 = mapper.Map<ReservationDTO>(data);
            return mapped2;
        }
    }
}
