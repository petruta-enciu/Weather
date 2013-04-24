using Ninject;
using Ninject.Syntax;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Web.Http.Dependencies;

namespace Mood.Weather.Web.App_Start
{
    internal class NinjectServiceModule : NinjectModule
    {
        public override void Load()
        {
            /*
            Bind<IFormsAuthenticationService>().To<FormsAuthenticationService>();
            Bind<IMembershipService>().To<AccountMembershipService>();
            Bind<IDatabaseFactory>().To<DatabaseFactory>();
            Bind<IAccountRepository>().To<AccountRepository>();
            // etc, etc.
             */ 
        }

    }
}