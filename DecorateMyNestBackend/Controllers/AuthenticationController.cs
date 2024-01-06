using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/authentications")]
    public class AuthenticationController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Authentications = AuthenticationService.GetAuthentications();
                return Ok(Authentications);
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
                var Authentication = AuthenticationService.GetAuthenticationById(id);
                return Ok(Authentication);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(AuthenticationDTO obj)
        {
            try
            {
                var createdAuthentication = AuthenticationService.CreateAuthentication(obj);
                return Ok(createdAuthentication);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<AuthenticationDTO> Authentications)
        {
            try
            {
                var createdAuthentications = new List<AuthenticationDTO>();

                foreach (var Authentication in Authentications)
                {
                    var createdAuthentication = AuthenticationService.CreateAuthentication(Authentication);
                    createdAuthentications.Add(createdAuthentication);
                }

                return Ok(createdAuthentications);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(AuthenticationDTO obj)
        {
            try
            {
                var updatedAuthentication = AuthenticationService.UpdateAuthentication(obj);
                return Ok(updatedAuthentication);
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
                var result = AuthenticationService.DeleteAuthentication(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
