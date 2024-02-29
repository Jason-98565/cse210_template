using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomnumber = new Random();
        int num = randomnumber.Next(1,100);
        
        int guess;
        guess = -1;
        
        do
        {
        Console.Write("Guess a number");
        string guess_str = Console.ReadLine();
        guess = int.Parse(guess_str);
        if (guess > num)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < num)
        {
            Console.WriteLine("Higher");
        }
        else if (guess == num)
        {
            Console.WriteLine("You guessed it!");
            num = -9999999;

        }
        }
        while (num != -9999999);
    }
}