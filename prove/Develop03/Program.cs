using System;

class Program
{
    static void Main()
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words have been hidden. Well done!");
                break;
            }
        }
    }
}
