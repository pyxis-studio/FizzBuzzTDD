namespace FizzBuzzTDD
{
    public class Greeter
    {
        private readonly IOutput _output;

        public Greeter(IOutput output)
        {
            _output = output;
        }

        public void SayHello(string name)
        {
            _output.WriteLine($"Hello {name}!");
        }
    }
}
