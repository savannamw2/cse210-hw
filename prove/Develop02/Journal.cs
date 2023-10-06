using System;
using System.IO; 
using System.Collections.Generic; 
public class Journal 
{

    public List<string> Entries = new List<string>();    

    public void Display()
    {
        foreach (string i in Entries)
        {
            Console.WriteLine(i);
        }

    } 
    public void writeToJournalFile() 
    {
        string fileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach(string entry in Entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadFromJournalFile() 
    {
        string fileName = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void printJournal()
    {
        LoadFromJournalFile(); // Load entries from the file

    }
    public void saveJournal()
    {
        writeToJournalFile(); // Call the method in the constructor, if needed
    }


}