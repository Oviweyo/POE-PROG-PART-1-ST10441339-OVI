using System;

namespace NetSecureBotChat
{
    internal static class ResponseHandler
    {
        public static string Handle(string input, string name)
        {
            string text = (input ?? string.Empty).Trim().ToLowerInvariant();

            if (string.IsNullOrEmpty(text))
                return "I didn't catch that. Please type a question about passwords, phishing, or browsing.";

            if (text == "exit")
                return $"Goodbye, {name}! Stay safe online.";

            if (text.Contains("how are you"))
                return $"I'm doing well, {name}. I'm here to help you stay safe online.";

            if (text.Contains("purpose"))
                return "My purpose is to help you understand cybersecurity and avoid online threats.";

            if (text.Contains("what can i ask") || text.Contains("help"))
                return "You can ask about password safety, phishing, safe browsing, and basic privacy tips.";

            if (text.Contains("password"))
                return "Use strong, unique passwords and consider a password manager to keep them safe.";

            if (text.Contains("phishing"))
                return "Phishing attempts try to trick you into revealing sensitive info—verify senders and never click suspicious links.";

            if (text.Contains("browsing") || text.Contains("website") || text.Contains("https"))
                return "Check for HTTPS, validate site certificates, and avoid entering credentials on unfamiliar pages.";

            return "I didn't quite understand that. Try asking about passwords, phishing, or safe browsing.";
        }
    }
}   