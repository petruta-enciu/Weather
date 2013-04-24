using System;
using System.Collections.Generic;
using System.Data;

namespace Mood.Weather.Domain.Factories
{
    public interface IDbConnectionFactory : IDbConnection
    {
        IDbConnection Create();
    }
}
