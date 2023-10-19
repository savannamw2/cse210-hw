using System; 

public class Scripture
{
    public string scripture;
    public List<Word> words; 

    public Scripture () {
        words = new List<Word>(); 
        scripture = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Split string into individual words
        string[] wordsList = scripture.Split(" ");
        // Create word object for each word in scripture
        foreach (string word in wordsList) {
            Word wordObject = new Word(word);
            words.Add(wordObject); 
        }
    }

    public void HideWords () 
    {
        Random rnd = new Random(); 
        int randomizeArray = rnd.Next(words.Count);
        while (words[randomizeArray].isHidden)
        {
            randomizeArray = rnd.Next(words.Count);
        }
        words[randomizeArray].isHidden = true;
    }

}