using NSubstitute;
using Xunit;

namespace FizzBuzzTDD.Tests
{
    public class GreeterTests
    {
        [Fact]
        public void SayHello_should_return_hello_with_name()
        {
            var output = Substitute.For<IOutput>();
            var greeter = new Greeter(output);

            greeter.SayHello("world");

            output.Received().WriteLine(Arg.Is<string>("Hello world!"));
        }
    }
}
