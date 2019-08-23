using System.Diagnostics;
using DemoApp.Core;

namespace DemoApp.Infrastructure
{
    public class TraceLogger : ILogger
    {
        public void Log(string content)
        {
            Debug.WriteLine(content);
        }
    }
}