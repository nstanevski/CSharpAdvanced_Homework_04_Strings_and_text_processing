using System;

// Write a program that reads a string from the console, reverses it 
// and prints the result back at the console.

class ReverseString
{
    static void Main(string[] args)
    {
        char[] charArr = Console.ReadLine().ToCharArray();
        Array.Reverse(charArr);
        string reversed = new string(charArr);
        Console.WriteLine(reversed);
    }
}