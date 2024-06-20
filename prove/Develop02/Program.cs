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
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Write your entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, entryText);
                    myJournal.AddEntry(newEntry);
                }
                else if (choice == "2")
                {
                    myJournal.ViewEntries();
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }
    }
}
