using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace Weather.Api
{
   
    [ServiceContract (Name = "WebApi",Namespace = "http://moodmedia.com/api")]
    public interface IHealth
    {
       [OperationContract ]
       [Description("Method to  check  status of this service")]
       [WebInvoke(Method = "GET", UriTemplate = "health")]
        string HealthStatus();

    }




}
