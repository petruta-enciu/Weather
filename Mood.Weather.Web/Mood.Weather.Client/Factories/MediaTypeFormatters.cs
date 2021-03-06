﻿using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

using Mood.Weather.Client.Factories;
using Mood.Weather.Domain;

namespace Mood.Weather.Client
{
    public class MediaTypeFormatters
    {
        private static MediaTypeFormatters _instance;
        private MediaTypeFormatterCollection formatters;

        protected MediaTypeFormatters()
        {
            formatters = new MediaTypeFormatterCollection();

            IMediaTypeFormatterFactory jsonFactory = new JsonFormatterFactory();
            formatters.Add(jsonFactory.Formatter());
            IMediaTypeFormatterFactory xmlFactory = new XmlFormatterFactory();
            formatters.Add(xmlFactory.Formatter());
        }

        public static MediaTypeFormatters Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new MediaTypeFormatters();
                }
                return _instance;
            }
        }

        public MediaTypeFormatter Create(string contentType)
        {
            
            if (contentType == HttpContentTypes.ApplicationXml)
            {
                return formatters.XmlFormatter;
            }

            if (contentType == HttpContentTypes.ApplicationJson)
            {
                return formatters.JsonFormatter;
            }

            throw new Exception(contentType + " is not a valid contentType for the MediaTypeFormatters");
        }
 

    }
}
