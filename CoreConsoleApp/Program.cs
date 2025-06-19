using GreetingMessageFormatterLib;

namespace CoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var username = ResolveUsernameArg(args);

            PrintGreetingMessage(username);
        }

        static void PrintGreetingMessage(string username)
        {
            var greetingMessage = GreetingMessageFormatter.FormatGreetingMessage(username);
            Console.WriteLine(greetingMessage);
        }

        // simplified solution
        static string ResolveUsernameArg(string[] args)
        {
            if (args.Length == 0)
            {
                throw new InvalidOperationException("Username argument was not specified");
            }

            return args[0];
        }
    }
}
