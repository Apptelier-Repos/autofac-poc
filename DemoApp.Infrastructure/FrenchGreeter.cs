using DemoApp.Core;

namespace DemoApp.Infrastructure
{
    public class FrenchGreeter : IGreeter
    {
        public string Greetings()
        {
            return "Salut!";
        }
    }
}