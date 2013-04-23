using System;
using System.Security.Permissions;
using System.ServiceModel.Activation;
using System.Web.Routing;

namespace Weather.Api
{
    public class Global : System.Web.HttpApplication
    {
       

        protected void Application_Start(object sender, EventArgs e)
        {
           RouteTable.Routes.Add(new ServiceRoute("api", new WebServiceHostFactory(), typeof(Health)));
        }

    }
}