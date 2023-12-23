using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AppointmentService
    {
        public static List<AppointmentDTO> GetAppointments()
        {
            var data = DataAccessFactory.AppointmentData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Appointment, AppointmentDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<AppointmentDTO>>(data);
            return mapped;
        }

        public static AppointmentDTO GetAppointmentById(int id)
        {
            var data = DataAccessFactory.AppointmentData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Appointment, AppointmentDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<AppointmentDTO>(data);
            return mapped;
        }

        public static AppointmentDTO CreateAppointment(AppointmentDTO appointment)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Appointment, AppointmentDTO>();
                c.CreateMap<AppointmentDTO, Appointment>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Appointment>(appointment);
            var data = DataAccessFactory.AppointmentData().Create(mapped);
            var mapped2 = mapper.Map<AppointmentDTO>(data);
            return mapped2;
        }

        public static bool DeleteAppointment(int id)
        {
            return DataAccessFactory.AppointmentData().Delete(id);
        }

        public static AppointmentDTO UpdateAppointment(AppointmentDTO appointment)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Appointment, AppointmentDTO>();
                c.CreateMap<AppointmentDTO, Appointment>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Appointment>(appointment);
            var data = DataAccessFactory.AppointmentData().Update(mapped);
            var mapped2 = mapper.Map<AppointmentDTO>(data);
            return mapped2;
        }
    }
}
