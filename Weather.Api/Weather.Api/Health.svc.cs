using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Weather.Api
{
     [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Health : IHealth
    {

        #region IHealth Members
       
        public string GetHealthXml()
        {
            return ("REST SERVICE IS UP  AND  RUNNING");

        }


        public string GetHealthJson()
        {
            return ("REST SERVICE IS UP  AND  RUNNING");

        }

     

        #endregion
    }
}
