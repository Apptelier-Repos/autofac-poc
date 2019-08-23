using System;
using System.Reflection;
using Autofac;
using DemoApp.Core;
using DemoApp.Infrastructure;
using Module = Autofac.Module;

namespace DemoApp.Modules
{
    public class LoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new Pear(c.Resolve<ILogger>())).As<IFruit>();
            builder.Register(c => new Apple(c.Resolve<ILogger>())).As<IFruit>();

            var ass = Assembly.GetAssembly(typeof(FrenchGreeter));
            builder.RegisterAssemblyTypes(ass).AsImplementedInterfaces();
            //builder.Register(c => new ConsoleLogger()).As<ILogger>();
            //builder.Register(c => new TraceLogger()).As<ILogger>().PreserveExistingDefaults();
        }


    }
}
