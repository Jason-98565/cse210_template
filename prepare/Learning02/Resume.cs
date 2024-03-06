using System;

public class Resume
{
    public string name;
    public List<Job> job_list = new List<Job>();

    public void Display_Resume()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in job_list)
        {
            job.Display();
        }
    }
}