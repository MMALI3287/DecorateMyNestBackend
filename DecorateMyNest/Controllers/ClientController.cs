using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace DecorateMyNest.Controllers
{
    public class ClientController : ApiController
    {
        [HttpGet]
        [Route("api/clients")]
        public HttpResponseMessage GetClients()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ClientService.GetClients());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,new {Message =ex.Message});
            }
        }

        [HttpGet]
        [Route("api/clients/{id}")]
        public HttpResponseMessage GetClientsById(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ClientService.GetClientById(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/clients/create")]
        public HttpResponseMessage Create(ClientDTO obj)
        {
            try
            {
                var data = ClientService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/clients/update")]
        public HttpResponseMessage Update(ClientDTO obj)
        {
            try
            {
                var data = ClientService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,new {Message = ex.Message});
            }
        }

    }
}
