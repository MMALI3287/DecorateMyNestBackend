using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/clients")]
    public class ClientController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var clients = ClientService.GetClients();
                return Ok(clients);
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
                var client = ClientService.GetClientById(id);
                return Ok(client);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(ClientDTO obj)
        {
            try
            {
                var createdClient = ClientService.CreateClient(obj);
                return Ok(createdClient);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<ClientDTO> clients)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(ClientDTO obj)
        {
            try
            {
                var updatedClient = ClientService.UpdateClient(obj);
                return Ok(updatedClient);
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
                var result = ClientService.DeleteClient(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
