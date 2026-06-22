namespace WarningAsErrors
{
    internal class HelloWorld
    {
        public required string Name { get; set; }

        public string SayHello()
        {
            return $"Hello World! to {Name}";
        }
    }
}
