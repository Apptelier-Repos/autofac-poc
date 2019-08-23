using System;
using DemoApp.Core;

namespace DemoApp.Infrastructure
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string content)
        {
            Console.WriteLine(content);
        }
    }
}