namespace FizzBuzzTDD.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter(new ConsoleOutput());
            greeter.SayHello("world!");
        }
    }
}
