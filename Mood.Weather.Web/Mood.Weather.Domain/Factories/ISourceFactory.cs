using System;
using System.Collections.Generic;

namespace Mood.Weather.Domain.Factories
{
    // describe a generic source
    public interface ISourceFactory
    {
        ISourceFactory Create();
    }
}
