using System;

namespace GreetingMessageFormatterLib
{
    public static class GreetingMessageFormatter
    {
        public static string FormatGreetingMessage(string username)
        {
            string currentTime = DateTime.Now.ToString();

            return $"{currentTime} Hello, {username}";
        }
    }
}
