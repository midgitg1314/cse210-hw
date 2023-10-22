class Reference
{
    public int _bookNumber;
    public string _book;
    public int _chapter;
    public int _startingVerse;
    public int _endingVerse;

    //public Reference() { }
    public Reference(int bookNumber, string book, int chapter, int verse)
    {
        _bookNumber = bookNumber;
        _book = book;
        _chapter = chapter;
        _startingVerse= verse;
    }

    public override string ToString()
    {
        return $"{_bookNumber}{_book} {_chapter}: {_startingVerse}";
    }
}