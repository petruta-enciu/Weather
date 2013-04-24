using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

using Mood.Weather.Domain;


namespace Mood.Weather.Client
{
    public class WebApiClient
    {
        public HttpClient Client { get; private set; }
        public IEnumerable<MediaTypeFormatter> Formatters { get; private set; }
        public string ContentType { get; private set; }
        public MediaTypeFormatter CurrentFormatter { get; private set; }

        private readonly TimeSpan _defaultTimeout = new TimeSpan(0, 15, 0);
        private const long DefaultMaxResponseContentBufferSize = 2100000000;

        public WebApiClient(string endpointUrl, string contentType = HttpContentTypes.ApplicationXml)
        {
            ContentType = contentType;
            CurrentFormatter = MediaTypeFormatters.Instance.Create(contentType);

            Client = new HttpClient(new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                });

            Client.BaseAddress = new Uri(endpointUrl);
            Client.MaxResponseContentBufferSize = DefaultMaxResponseContentBufferSize;
            Client.Timeout = _defaultTimeout;
            
            
            var headers = Client.DefaultRequestHeaders;
            headers.ConnectionClose = true;
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType));
            Formatters = new[]
                              {
                                  CurrentFormatter
                              };
        }

        #region HttpClient settings

         public TimeSpan ClientTimeOut
        {
            get
            {
                return Client.Timeout;
            }
            set
            {
                // minimum accepted value are bigger the _defaultTimeout
               Client.Timeout = TimeSpan.Compare(value, _defaultTimeout) > 0 ? value : _defaultTimeout;
            }
        }

        public long ClientMaxResponseContentBufferSize
        {
            get
            {
                return Client.MaxResponseContentBufferSize;
            }
            set
            {
                // minimum accepted value are bigger the DefaultMaxResponseContentBufferSize
                Client.MaxResponseContentBufferSize = Math.Max(value, DefaultMaxResponseContentBufferSize);
            }
        }

        public void SetClientDownloadsDefaults()
        {
            Client.MaxResponseContentBufferSize = DefaultMaxResponseContentBufferSize;
            Client.Timeout = _defaultTimeout;
        }

        #endregion


        #region Mood Weather API Methods exposed for client calls
        #endregion

    }
}
