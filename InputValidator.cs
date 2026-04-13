using System;

namespace NetSecureBotChat
{
    internal static class InputValidator
    {
        public static bool Check(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}