using System;
using System.Collections.Generic;

namespace JournalApp
{
    class PromptGenerator
    {
        private List<string> prompts;

        public PromptGenerator()
        {
            prompts = new List<string>
            {
                "What are you grateful for today?",
                "Describe a recent challenge you overcame.",
                "What are your goals for the next week?",
                "Write about a happy memory from your childhood.",
                "What is something new you learned recently?"
            };
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
