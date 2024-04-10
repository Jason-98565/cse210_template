using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Doe","CSE 110");
        Console.WriteLine(a1.GetSummary());

        Math m1 = new Math("John Doe jr.","Math 109","Page 381","14-25");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.Homework());

        Writing w1 = new Writing("Jane Doe III","ENG 151","Why am I spending this long writing this?");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.titlename());
    }
}