using System; 

public class Reference
{
    public string book {get; set;} 
    public int chapter {get; set;} 
    public int verse {get; set;}
    
    public int endVerse {get; set;}
    private string reference;
    
    public Reference(int oneVerse, int secondVerse=0) {
        book = "Proverbs";
        chapter = 3;  
        verse = oneVerse;
        endVerse = secondVerse;
        if (secondVerse == 0) {
            reference = $"{book} {chapter}:{verse}";    
        }
        else {
            reference = $"{book} {chapter}:{verse}-{secondVerse}";
        }
    }

    public string getReference() {
        return reference;
    }
}