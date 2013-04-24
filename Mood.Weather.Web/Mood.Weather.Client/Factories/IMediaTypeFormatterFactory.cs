using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;

namespace Mood.Weather.Client.Factories
{
    public interface IMediaTypeFormatterFactory
    {
        IMediaTypeFormatterFactory Create();
        MediaTypeFormatter Formatter();
    }
}
