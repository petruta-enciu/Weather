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
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "health/xml/")]
        string GetHealthXml();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "health/json/")]
        string GetHealthJson();

   

        //[OperationContract]
        //[WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "delete/{id}")]
        //string DeleteJob(string id);

        //[OperationContract]
        //[WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "insert/{id}")]
        //string InsertJob(string id);

    }




}
