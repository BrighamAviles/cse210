using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            while (true)
            {
                Console.WriteLine("Welcome to your Journal!");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. View Entries");
                Console.WriteLine("3. Save Entries to File");
                Console.WriteLine("4. Load Entries from File");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Write your entry: ");
                        string entryText = Console.ReadLine();
                        Entry newEntry = new Entry(prompt, entryText);
                        myJournal.AddEntry(newEntry);
                        break;
                    case "2":
                        myJournal.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Enter filename to save: ");
                        string saveFilename = Console.ReadLine();
                        myJournal.SaveToFile(saveFilename);
                        break;
                    case "4":
                        Console.Write("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        myJournal.LoadFromFile(loadFilename);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
