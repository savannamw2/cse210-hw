public class Word {
    public string text {get; set;}
    public bool isHidden {get; set;}
    public Word (string word) {
        text = word;
        isHidden = false;
    }
}