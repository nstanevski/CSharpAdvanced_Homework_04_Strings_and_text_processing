using System;
using System.Linq;
using System.Threading;

//https://judge.softuni.bg/Contests/Practice/DownloadResource/452
// В Judge ми дава 80/100; гърмят тестове №2 и №10

class LettersChangeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = 
            System.Globalization.CultureInfo.InvariantCulture;
        char[] separators = {' ','\t' };
        string[] words = Console.ReadLine().Split(separators, 
            StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
        
        double sum=0.0;
        foreach (string word in words)
        {
            char prefix = word[0];
            char suffix = word[word.Length - 1];
            double number = double.Parse(word.Substring(1, word.Length - 2));

            if (Char.IsUpper(prefix))
                number /= 1.00*((int)prefix - (int)'A' + 1);
            else
                number *= 1.00 * ((int)prefix - (int)'a' + 1);

            if (Char.IsUpper(suffix))
                number -= ((int)suffix - (int)'A' + 1);
            else
                number += ((int)suffix - (int)'a' + 1);

            sum += number;
        }
        Console.WriteLine("{0:F2}", sum);
    }
}