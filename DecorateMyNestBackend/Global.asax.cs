using System.Web.Http;
using System.Web.Http.Cors;

namespace DecorateMyNestBackend
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var cors = new EnableCorsAttribute("http://localhost:5173", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(cors);
        }
    }
}
