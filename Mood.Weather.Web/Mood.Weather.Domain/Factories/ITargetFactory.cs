using System;
using System.Collections.Generic;

namespace Mood.Weather.Domain.Factories
{
    // describe a generic target 
    public interface ITargetFactory
    {
        ITargetFactory Create();
    }
}
