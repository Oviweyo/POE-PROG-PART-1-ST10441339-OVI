using System;
using System.Threading;

namespace NetSecureBotChat
{
    public static class ConsoleUI
    {
        public static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("              __                   _          _             \r\n |\\ |  _ _|_ (_   _   _     ._ _  |_)  _ _|_ /  |_   _. _|_ \r\n | \\| (/_ |_ __) (/_ (_ |_| | (/_ |_) (_) |_ \\_ | | (_|  |_ \r\n                                                            ");
            Console.ResetColor();
        }

        public static void BotReply(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (char c in "Bot: " + message)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static void UserPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ResetColor();
        }
    }
}