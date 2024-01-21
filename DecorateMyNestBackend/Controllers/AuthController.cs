using BLL.Services;
using DecorateMyNestBackend.Auth;
using DecorateMyNestBackend.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DecorateMyNestBackend.Controllers
{
    public class AuthController : ApiController
    {

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel obj)
        {
            try
            {
                var data = AuthService.Authenticate(obj.username, obj.password);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Massage = "User not found" });

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/googlelogin/{username}")]
        public HttpResponseMessage GoogleLogin(string username)
        {
            try
            {
                var data = AuthService.GoogleTokenCreate(username);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Massage = "Token creation failed" });

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/authtoken/{token}")]
        public HttpResponseMessage IsTokenValid(string token)
        {
            try
            {
                var result = AuthService.IsTokenValid(token);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/authuser/{username}")]
        public HttpResponseMessage UserExist(string username)
        {
            try
            {
                var result = AuthService.UserExist(username);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }

        [Logged]
        [HttpPut]
        [Route("api/logout/{username}")]
        public HttpResponseMessage Logout(string username)
        {
            try
            {
                var result = AuthService.Logout(username);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }

        [Logged]
        [HttpGet]
        [Route("api/tokens/")]
        public IHttpActionResult Get()
        {
            try
            {
                var Auths = TokenService.GetTokens();
                return Ok(Auths);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
