using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
    
            switch (choice)
            {
                case "1":      
                    entry.Display();
                    Console.Write("> ");
                    entry._entry = Console.ReadLine();
                    Console.Write("Written By: ");
                    entry.Name = Console.ReadLine();
                    journal.Entries.Add(entry.createEntry());
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    journal.saveJournal();
                    Console.Write("Entries are being saved to Journal!\n");
                    break;
                case "4":
                    journal.printJournal();
                    Console.Write("Entries from Journal:\n"); 
                    break;
                case "5": 
                    isRunning = false; 
                    break; 
                default:
                break;
            }         
    }
    
}
    }