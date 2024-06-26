using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> words;
    public Reference Reference { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                var wordToHide = visibleWords[random.Next(visibleWords.Count)];
                wordToHide.Hide();
                visibleWords.Remove(wordToHide);
            }
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", words)}";
    }
}
