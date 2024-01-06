using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Orders = OrderService.GetOrders();
                return Ok(Orders);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                var Order = OrderService.GetOrderById(id);
                return Ok(Order);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(OrderDTO obj)
        {
            try
            {
                var createdOrder = OrderService.CreateOrder(obj);
                return Ok(createdOrder);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<OrderDTO> Orders)
        {
            try
            {
                var createdOrders = new List<OrderDTO>();

                foreach (var Order in Orders)
                {
                    var createdOrder = OrderService.CreateOrder(Order);
                    createdOrders.Add(createdOrder);
                }

                return Ok(createdOrders);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(OrderDTO obj)
        {
            try
            {
                var updatedOrder = OrderService.UpdateOrder(obj);
                return Ok(updatedOrder);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var result = OrderService.DeleteOrder(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
