using System;

namespace NetSecureBotChat
{
    public class Chatbot
    {
        private string name;

        public void Run()
        {
            AskName();

            while (true)
            {
                ConsoleUI.UserPrompt();
                string input = Console.ReadLine()?.Trim();

                if (!InputValidator.Check(input))
                {
                    ConsoleUI.BotReply("Please type something.");
                    continue;
                }

                string response = ResponseHandler.Handle(input, name);

                ConsoleUI.BotReply(response);

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
            }
        }

        private void AskName()
        {
            ConsoleUI.BotReply("Hello! What's your name?");

            name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
                name = "User";

            // 🔊 AUDIO ONLY HERE (AFTER NAME INPUT)
            AudioPlayer.PlayGreeting();

            ConsoleUI.BotReply($"Nice to meet you, {name}! I'm your NetSecureBotChat Assistant.");
        }
    }
}