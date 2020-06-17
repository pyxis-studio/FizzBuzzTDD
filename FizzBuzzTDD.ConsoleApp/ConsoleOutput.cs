using System;

namespace FizzBuzzTDD.ConsoleApp
{
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
