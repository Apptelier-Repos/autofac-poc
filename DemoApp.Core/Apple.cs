namespace DemoApp.Core
{
    public class Apple : IFruit
    {
        private readonly ILogger _logger;
        private readonly string _parentPlant;

        public string ParentPlant
        {
            get
            {
                _logger.Log($"{nameof(ParentPlant)} = {_parentPlant}");
                return _parentPlant;
            }
        }

        public Apple(ILogger logger)
        {
            _logger = logger;
            _parentPlant = "Apple tree";
            _logger.Log($"New fruit 🍎 {nameof(Apple)} created.");
        }
    }
}