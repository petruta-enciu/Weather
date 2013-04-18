using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Weather.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "www.moodmedia.com")]
    public interface IGetHealth
    {
        [OperationContract]
        [WebGet(UriTemplate = "/get/health")]
        String health();
    }


  
}
