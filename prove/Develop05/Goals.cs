using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

public class Goals
{
    List<Goal> gulls = new List<Goal>();
    public int points;
    public void MarkComplete()
    {
        int i = 0;
        foreach (Goal entry in gulls)
        {
            i++;
            Console.WriteLine($"{i}. {entry._goalname}");
        }
        Console.WriteLine("Select a choice from the menu");
        string Fe =Console.ReadLine();
        int cho1ce = int.Parse(Fe);
        Goal chosen =gulls[cho1ce];
        chosen.ToString();
    }
    public void Saving(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
                {
                outputFile.WriteLine(points);
                foreach (Goal goal in gulls)
                outputFile.WriteLine(goal); 
                }
        }
    public void _displayGoals()
    {
        Console.WriteLine();
        foreach (Goal entry in gulls)
        {
            Console.WriteLine(entry.ToString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        string Z = Console.ReadLine();
        int choice = int.Parse(Z);
        Console.WriteLine("What are you naming your goal?");
        string Y = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal?");
        string X = Console.ReadLine();
        Console.WriteLine("How many points is this worth?");
        string W = Console.ReadLine();
        int Value = int.Parse(W);
        if (choice == 1)
        {
          Simple S = new Simple(Value,Y,X);
          gulls.Add(S);
        }
        if (choice == 2)
        {
            Eternal E = new Eternal(Value,Y,X);
            gulls.Add(E);
        }
        if (choice == 3)
        {
            Console.WriteLine("How many times do you need to complete the goal to get a bonus?");
            string V = Console.ReadLine();
            int numb3r = int.Parse(W);
            Console.WriteLine("How many points is the bonus?");
            string U = Console.ReadLine();
            int nVmb3r = int.Parse(W);
            Checklist Ch = new Checklist(Value,Y,X,numb3r,nVmb3r);
            gulls.Add(Ch);
        }
    }
}