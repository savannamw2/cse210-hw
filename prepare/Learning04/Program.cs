using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Savanna Mays", "Programming");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Savanna Mays", "Algorithim Design", "Lab 6.0", "1-10");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
    
        WritingAssignment w1 = new WritingAssignment("Savanna Mays", "English 101", "The Effects of Facial Recognition");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}