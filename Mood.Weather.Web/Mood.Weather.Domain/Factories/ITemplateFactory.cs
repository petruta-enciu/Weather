using System;
using System.Collections.Generic;

namespace Mood.Weather.Domain.Factories
{
    // describe generic configurable format of exported data
    interface ITemplateFactory
    {
        ITemplateFactory Create();
    }
}
