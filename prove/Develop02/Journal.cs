using System;
using System.IO; 
using System.Collections.Generic; 
public class Journal 
{

    public List<string> Entries = new List<string>();    

    public void Display()
    {
        foreach (string entry in Entries)
        {
            Console.WriteLine(entry);
        }

    } 
    public void WriteToJournalFile() 
    {
        string FileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(FileName, true))
        {
            foreach(string response in Entries)
            {
                outputFile.WriteLine(response);
            }
        }
    }

    public void LoadFromJournalFile() 
    {
        string FileName = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(FileName);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void PrintJournal()
    {
        LoadFromJournalFile(); // Load entries from the file

    }
    public void SaveJournal()
    {
        WriteToJournalFile(); // Call the method in the constructor, if needed
    }


}