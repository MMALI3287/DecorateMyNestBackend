using BLL.Services;
using DecorateMyNestBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNestBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        [Route("~/api/login")]
        public IActionResult Login(LoginModel obj)
        {
            try
            {
                var data = AuthService.Authenticate(obj.username, obj.password);
                if (data != null)
                {
                    return Ok(data); // 200 OK
                }
                else
                {
                    return NotFound(new { Message = "User not found" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        //[Logged]
        //[HttpGet]
        //[Route("api/logout")]
        //public HttpResponseMessage Logout()
        //{
        //    var token = Request.Headers.Authorization.ToString();
        //    try
        //    {
        //        var res = AuthService.Logout(token);
        //        return Request.CreateResponse(HttpStatusCode.OK, res);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
        //    }

        //}
    }
}
