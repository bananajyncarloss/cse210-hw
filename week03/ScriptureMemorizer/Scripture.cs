using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}