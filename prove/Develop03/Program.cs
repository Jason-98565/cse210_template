using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string input;
        string text = "Trust in the lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths";
        Passage passage = new Passage(text);
        Reference reference = new Reference();
        reference._Book = "Proverbs";
        reference._Chap = "3";
        reference._Verse = "5-6";
        reference.display_ref();
        
        Console.WriteLine("Press enter or type 'quit' to finish");
        do
        {
            Console.Clear();
            reference.display_ref();
            passage.Wrdss();
            Console.WriteLine("Press enter or type 'quit' to finish");
            passage.hide_words();
            input = Console.ReadLine();
        }
        while (input != "quit");
    }
}