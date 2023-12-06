using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling newCycle = new Cycling(); 
        Running newRun = new Running();
        Swimming newSwim = new Swimming();

        List<Activity> list = new List<Activity>();

        list.Add(newCycle); 
        list.Add(newRun); 
        list.Add(newSwim); 

        foreach (Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}