using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage");
        string score_str = Console.ReadLine();
        int score = int.Parse(score_str);
        string letter_grade = "";
        if (score >= 90)
        {
            letter_grade = "A";
        }
        else if (score >= 80)
        {
            letter_grade = "B";
        }
        else if (score >= 70)
        {
            letter_grade = "C";
        }
        else if (score >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }
        Console.WriteLine($"You got a(n) {letter_grade}");
        if (score >= 70)
        {
            Console.WriteLine("You have passed, Congragulations");
        }
        else
        {
            Console.WriteLine("You have failed, Better luck next time");
        }
    }
}