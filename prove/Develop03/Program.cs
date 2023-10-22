using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference(1, "Nephi", 3, 7);
        //reference._bookNumber = 1;
        //reference._book = "Nephi";
        //reference._chapter = 3;
        //reference._startingVerse = 7;

        Scripture scripture = new Scripture();
        scripture.Reference = reference;
        scripture.Words = new Words("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Console.WriteLine("Press Enter to reveal the scripture or type 'quit' to exit.");
        
        string userChoice = Console.ReadLine();

        while (userChoice != "quit")
        {
            scripture.Words.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture);
            userChoice = Console.ReadLine();
        }
    }
}