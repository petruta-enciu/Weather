using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Weather.Api
{
   
    [ServiceContract]
    public interface IHealth
    {
        [OperationContract]
        [WebInvoke(Method = "GET",UriTemplate = "health")]
        string GetHealth();
    }




}
