using System;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
        string input = Console.ReadLine();
        StringBuilder textBuilder = new StringBuilder(input);

        foreach (string bannedWord in bannedWords)
        {
            string mask = new string('*', bannedWord.Length);
            textBuilder.Replace(bannedWord, mask);
        }

        Console.WriteLine(textBuilder.ToString());
    }
}