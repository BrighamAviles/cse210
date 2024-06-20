using System;

namespace JournalApp
{
    class Entry
    {
        public string Prompt { get; private set; }
        public string Content { get; private set; }
        public DateTime Date { get; private set; }

        public Entry(string prompt, string content)
        {
            Prompt = prompt;
            Content = content;
            Date = DateTime.Now;
        }
    }
}
