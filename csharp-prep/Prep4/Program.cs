using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numlist = new List<int>();
        int num;
        int total = 0;
        int countcount = 0;
        float average = 0;
        int biggest_number = -9999999;
        Console.Write("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter Number:");
            string num_str =  Console.ReadLine();
            num = int.Parse(num_str);
            if (num != 0)
            {
                numlist.Add(num);
            }
        }
        while (num != 0);
        {
        for (int i = 0; i < numlist.Count; i++)
        {
            num = numlist[i];
            int number = num;
            total = total + number;
            countcount++;
            average = (float)total/countcount;
            if (number > biggest_number)
            {
                biggest_number = number;
            }
        }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The biggest number was: {biggest_number}");
    }
}