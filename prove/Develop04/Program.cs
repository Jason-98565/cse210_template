using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
        Console.WriteLine("Choose the activity you wish to perform");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        string c = Console.ReadLine();
        choice =int.Parse(c);
        if (choice == 1)
        {
            Breathing b = new Breathing();
        }
        else if (choice == 2)
        {
            Reflection r = new Reflection();
        }
        else if (choice == 3)
        {
            Listing l = new Listing();
        }
        } while (choice !=4);
    }
}