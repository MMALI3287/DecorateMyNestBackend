using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(AuthenticationDTO authentication)
        {
            try
            {
                var authorizationSuccessful = AuthService.Authenticate(authentication.UserName, authentication.Password);
                if (authorizationSuccessful != null)
                {
                    return Ok(authorizationSuccessful);
                }
                else return (IHttpActionResult)Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User not found" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}