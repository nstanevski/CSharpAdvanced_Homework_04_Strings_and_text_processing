using System;

/*
 * Write a program to find how many times a given string appears in a given text as substring.
 * The text is given at the first input line. The search string is given at the second input line.
 * The output is an integer number. Please ignore the character casing. Overlapping between 
 * occurrences is allowed.
 */

class CountSubstringOccurences
{
    static void Main()
    {
        string input = Console.ReadLine();
        string substring = Console.ReadLine();
        int numOccurences = 0;
        int startIndex = 0;
        
        while (input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) >= 0)
        {
            numOccurences++;
            startIndex = input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
        }
        Console.WriteLine(numOccurences);
    }
}