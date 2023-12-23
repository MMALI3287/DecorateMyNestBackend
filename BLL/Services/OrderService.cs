using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class OrderService
    {
        public static List<OrderDTO> GetOrders()
        {
            var data = DataAccessFactory.OrderData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<OrderDTO>>(data);
            return mapped;
        }

        public static OrderDTO GetOrderById(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<OrderDTO>(data);
            return mapped;
        }

        public static OrderDTO CreateOrder(OrderDTO Order)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
                c.CreateMap<OrderDTO, Order>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Order>(Order);
            var data = DataAccessFactory.OrderData().Create(mapped);
            var mapped2 = mapper.Map<OrderDTO>(data);
            return mapped2;
        }

        public static bool DeleteOrder(int id)
        {
            return DataAccessFactory.OrderData().Delete(id);
        }

        public static OrderDTO UpdateOrder(OrderDTO Order)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
                c.CreateMap<OrderDTO, Order>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Order>(Order);
            var data = DataAccessFactory.OrderData().Update(mapped);
            var mapped2 = mapper.Map<OrderDTO>(data);
            return mapped2;
        }
    }
}

