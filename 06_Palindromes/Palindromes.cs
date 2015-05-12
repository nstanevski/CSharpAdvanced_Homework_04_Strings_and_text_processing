using System;
using System.Linq;
using System.Collections.Generic;
//
//using System.Text;
//using System.Threading.Tasks;

/*
 * Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe 
 * and prints them on the console on a single line, separated by comma and space. 
 * Use spaces, commas, dots, question marks and exclamation marks as word delimiters. 
 * Print only unique palindromes, sorted lexicographically.
 */

class Palindromes
{
    private static bool IsPalyndrome(string word)
    {
        if (word.Length == 1)
            return true;
        if (word.Length == 0)
            return false;
        int len = word.Length;
        for(int i=0; i<len/2; i++){
            if(word[i] != word[len-i-1])
                return false;
        }
        return true;
    }

    static void Main()
    {
        char[] delimiters = {' ', ',', '.', '?', '!' };
        SortedSet<string> palyndromes = new SortedSet<string>();
        List<string> words = Console.ReadLine().Split(delimiters).Select(p => p.Trim()).ToList();

        foreach(string word in words){              
            if (IsPalyndrome(word))
                palyndromes.Add(word);
        }
        Console.WriteLine(string.Join(", ", palyndromes));
        
    }

   
}