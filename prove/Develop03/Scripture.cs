using System.Text.RegularExpressions;
class Scripture
{
    public Reference Reference {get; set;}
    public Words Words {get; set;}

    public Scripture() { }
    public override string ToString()
    {
        {
            return $"{Reference}: {Words}";
        }
    }
}

// string scripture;
// public class Scripture
// {
//     // Define a regular expression pattern to split the string by spaces or punctuation marks.
//     char static pattern = ' ';
//     string[] smallerStrings = scripture.Split(pattern);
// }

