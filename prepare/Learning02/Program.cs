using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "Sandvich Maker";
        job._company = "Sobuvey";
        job._startYear = 2022;
        job._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Redacted";
        job2._company = "Null";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume obj_Resume = new Resume();
        obj_Resume.name = "Jason R";

        obj_Resume.job_list.Add(job);
        obj_Resume.job_list.Add(job2);
        obj_Resume.Display_Resume();
    }
}