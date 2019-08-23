namespace DemoApp.Core
{
    public class Pear : IFruit
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

        public Pear(ILogger logger)
        {
            _logger = logger;
            _parentPlant = "Pear tree";
            _logger.Log($"New fruit 🍐 {nameof(Pear)} created.");
        }
    }
}