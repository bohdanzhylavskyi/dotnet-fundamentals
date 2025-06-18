using GreetingMessageFormatterLib;

namespace CoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var username = "Bohdan";

            PrintGreeting(username);
        }

        static void PrintGreeting(string username)
        {
            var greetingMessage = GreetingMessageFormatter.FormatGreetingMessage(username);
            Console.WriteLine(greetingMessage);
        }
    }
}
