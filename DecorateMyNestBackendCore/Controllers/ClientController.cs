using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/clients/")]
        public IActionResult Get()
        {
            try
            {
                var clients = ClientService.GetClients();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/clients/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var client = ClientService.GetClientById(id);
                return Ok(client);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/clients/")]
        public IActionResult Create(ClientDTO obj)
        {
            try
            {
                var createdClient = ClientService.CreateClient(obj);
                return Ok(createdClient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/clients/create-multiple")]
        public IActionResult Create(List<ClientDTO> clients)
        {
            try
            {
                var createdClients = new List<ClientDTO>();

                foreach (var client in clients)
                {
                    var createdClient = ClientService.CreateClient(client);
                    createdClients.Add(createdClient);
                }

                return Ok(createdClients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/clients/")]
        public IActionResult Update(ClientDTO obj)
        {
            try
            {
                var updatedClient = ClientService.UpdateClient(obj);
                return Ok(updatedClient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/clients/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = ClientService.DeleteClient(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
