using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Moses", 6, 34);
        string text = "Behold my Spirit is upon you, wherefore all thy words will I justify;\n" +
                    "and the mountains shall flee before you, and the rivers shall turn from their course;\n" +
                    "and thou shalt abide in me, and I in you; therefore walk with me.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AreAllWordsHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}