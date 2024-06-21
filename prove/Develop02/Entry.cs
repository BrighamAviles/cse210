using System;

namespace JournalApp
{
    class Entry
    {
        private DateTime _date;
        private string _promptText;
        private string _entryText;

        public DateTime Date => _date;
        public string PromptText => _promptText;
        public string EntryText => _entryText;

        public Entry(string promptText, string entryText)
        {
            _date = DateTime.Now;
            _promptText = promptText;
            _entryText = entryText;
        }

        public Entry(string promptText, string entryText, DateTime date)
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
        }
    }
}
