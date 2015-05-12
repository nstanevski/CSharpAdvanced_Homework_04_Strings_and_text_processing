using System;
using System.Text;

/*
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters 
 * should be filled with *. Print the resulting string on the console. 
 */

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb;
        if(input.Length>20){
            sb = new StringBuilder(input.Substring(0,20));
        }else{
            sb = new StringBuilder(input);
            while(sb.Length<20){
                sb.Append('*');
            }
        }
        Console.WriteLine(sb.ToString());   
    }
}
