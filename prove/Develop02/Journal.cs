using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries in the journal.");
            }
            else
            {
                foreach (var entry in _entries)
                {
                    entry.Display();
                    Console.WriteLine("---------------------------------");
                }
            }
        }

        public void SaveToFile(string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                }
            }
            Console.WriteLine("Entries saved to file.");
        }

        public void LoadFromFile(string file)
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new Entry(parts[1], parts[2], DateTime.Parse(parts[0]));
                        _entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Entries loaded from file.");
        }
    }
}
