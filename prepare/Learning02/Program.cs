using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Pinterest";
        job1._startYear = 2025;
        job1._endYear = 2027;

        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Spotify";
        job2._startYear = 2027;
        job2._endYear = 2030;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Savanna Mays";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    
    }
}