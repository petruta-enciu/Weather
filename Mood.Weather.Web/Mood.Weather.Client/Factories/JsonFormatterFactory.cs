using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Mood.Weather.Client.Factories
{
    public class JsonFormatterFactory : IMediaTypeFormatterFactory
    {
        IMediaTypeFormatterFactory IMediaTypeFormatterFactory.Create()
        {
            return new JsonFormatterFactory();
        }

        MediaTypeFormatter IMediaTypeFormatterFactory.Formatter()
        {
            var serializerSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>() { new IsoDateTimeConverter() }               
            };

            return new JsonMediaTypeFormatter()
            {
                SerializerSettings = serializerSettings,                
            };
        }





 
    }
}
