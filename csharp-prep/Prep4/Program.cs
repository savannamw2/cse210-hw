using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();

        int input = -1;
        while (input != 0)
        {
          Console.Write("Enter a number: ");
          string number = Console.ReadLine();
          input = int.Parse(number);
          


          if (input != 0)
        {
            numbers.Add(input);
        }

        }

        int total  = 0;  
        foreach (int num in numbers)
        {
           total += num;  
        }

        float average = ((float) total) / numbers.Count;

        int max = 0; 

        foreach (int item in numbers)
        {
            if (item > max)
            {
                max = item; 
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}