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

        Console.WriteLine("Press enter or type 'quit' to finish");
        do
        {
            bool existance = false;
            Console.Clear();
            reference.display_ref();
            string check = passage.Wrdss();
            for (int i = 0; i < check.Length; i++)
            {
                if ((check[i] != '_') && (check[i] != ' '))
                {
                    existance = true;
                } 
            }
            Console.WriteLine("Press enter or type 'quit' to finish");
            passage.hide_words();
            input = Console.ReadLine();
            if (existance == false)
            {
                input = "quit";
            }
        }
        while (input != "quit");
    }
}