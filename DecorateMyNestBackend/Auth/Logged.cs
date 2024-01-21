using BLL.Services;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace DecorateMyNestBackend.Auth
{
    public class Logged : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { Message = "No token" });
            }
            else
            {
                var cleanedToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring("Bearer ".Length) : token.ToString();
                if (!AuthService.IsTokenValid(cleanedToken))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { Message = $"{cleanedToken} token not valid" });
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}