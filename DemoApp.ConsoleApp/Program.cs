using System;
using System.Reflection;
using Autofac;
using DemoApp.Core;
//using DemoApp.Modules;

namespace DemoApp.ConsoleApp
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ContainerBuilder();
            //var module = new LoggingModule();
            //builder.RegisterModule(module);
            //var assembly = typeof(LoggingModule).Assembly;
            var assembly = Assembly.LoadFrom("DemoApp.Modules.dll");
            builder.RegisterAssemblyModules(assembly);

            Container = builder.Build();

            DoSomething();
        }

        public static void DoSomething()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var x = scope.Resolve<IFruit>();
                Console.WriteLine(x.ParentPlant);
                Console.ReadLine();
            }
        }
    }
}
