using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/authentications")]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/authentications/")]
        public IActionResult Get()
        {
            try
            {
                var Authentications = AuthenticationService.GetAuthentications();
                return Ok(Authentications);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/authentications/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Authentication = AuthenticationService.GetAuthenticationById(id);
                return Ok(Authentication);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/authentications/")]
        public IActionResult Create(AuthenticationDTO obj)
        {
            try
            {
                var createdAuthentication = AuthenticationService.CreateAuthentication(obj);
                return Ok(createdAuthentication);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/authentications/create-multiple")]
        public IActionResult Create(List<AuthenticationDTO> Authentications)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/authentications/")]
        public IActionResult Update(AuthenticationDTO obj)
        {
            try
            {
                var updatedAuthentication = AuthenticationService.UpdateAuthentication(obj);
                return Ok(updatedAuthentication);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/authentications/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = AuthenticationService.DeleteAuthentication(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}