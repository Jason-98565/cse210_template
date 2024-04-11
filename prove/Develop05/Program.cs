using System;
using System.Runtime.CompilerServices;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Goals mongoals = new Goals();
        do 
        {
            Console.WriteLine($"Points: {mongoals.points}");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            string choosestring = Console.ReadLine();
            choice = int.Parse(choosestring);
            if (choice == 1)
            {
                mongoals.CreateGoal();
            }
            else if (choice == 2)
            {
                mongoals._displayGoals();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What filename would you like to save the file as?");
                string filename = Console.ReadLine();
                mongoals.Saving(filename);
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                
            }
            else
            {
                Console.WriteLine("");
            }
        } while (choice !=6);
        //Load
        //Save
        //New
        //Record
        //Display
    }
}