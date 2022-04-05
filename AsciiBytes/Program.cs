using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();
        byte[] asciiBytes = Encoding.ASCII.GetBytes(S);
        int total = 0;
        foreach(var i in asciiBytes)
        {
            total += i;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(total);
    }
}
