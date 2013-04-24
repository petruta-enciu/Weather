using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;

namespace Mood.Weather.Client.Factories
{
    public class XmlFormatterFactory : IMediaTypeFormatterFactory
    {
        IMediaTypeFormatterFactory IMediaTypeFormatterFactory.Create()
        {
            return new XmlFormatterFactory();
        }

        MediaTypeFormatter IMediaTypeFormatterFactory.Formatter()
        {
            return new XmlMediaTypeFormatter()
                            {
                                UseXmlSerializer = true
                            };
        }

  
    }
}
