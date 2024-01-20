using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/orders/")]
        public IActionResult Get()
        {
            try
            {
                var Orders = OrderService.GetOrders();
                return Ok(Orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/orders/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Order = OrderService.GetOrderById(id);
                return Ok(Order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/orders/")]
        public IActionResult Create(OrderDTO obj)
        {
            try
            {
                var createdOrder = OrderService.CreateOrder(obj);
                return Ok(createdOrder);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/orders/create-multiple")]
        public IActionResult Create(List<OrderDTO> Orders)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/orders/")]
        public IActionResult Update(OrderDTO obj)
        {
            try
            {
                var updatedOrder = OrderService.UpdateOrder(obj);
                return Ok(updatedOrder);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/orders/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = OrderService.DeleteOrder(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
