class Words
{
 private List<string> words;

 public Words(string text)
 {
    words = text.Split(' ').ToList();
 }

 public void HideRandomWord()
 {
    if (words.Count > 0)
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index] = new string('_', words[index].Length);
    }
 }
    public override string ToString()
    {
        return string.Join(" ", words);
    }
}