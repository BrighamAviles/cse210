using System;
using System.Collections.Generic;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void ViewEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries in the journal.");
            }
            else
            {
                foreach (var entry in entries)
                {
                    Console.WriteLine($"Date: {entry.Date}");
                    Console.WriteLine($"Prompt: {entry.Prompt}");
                    Console.WriteLine($"Entry: {entry.Content}");
                    Console.WriteLine("---------------------------------");
                }
            }
        }
    }
}
