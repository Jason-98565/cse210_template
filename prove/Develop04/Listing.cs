using System;

public class Listing:Activity
{
    public Listing()
    {
        _name = "Listing Activity";
        _description = "";
        Startmessage();
        getduration();
        Pause_Speen(5);
        int count = 0;
        Question();
        Pause_Speen(10);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        do
        {
            Console.WriteLine("");
            Console.ReadLine();
            count++;
            currentTime = DateTime.Now;
        }
        while (currentTime < endTime);
        Console.WriteLine($"You answered {count} times!");
        Endmessage();
    }
        public void Question()
    {
        List<string> stro = new List<string>();
        stro.Add("Who are people that you appreciate");
        stro.Add("What are personal strengths of yours?");
        stro.Add("Who are people that you have helped this week?");
        stro.Add("When have you felt the Holy Ghost this month?");
        stro.Add("Who are some of your personal heroes?");
        Random ran = new Random();
        int value = ran.Next(0,stro.Count);
        string str = stro[value];
        Console.WriteLine(str);
    }
}