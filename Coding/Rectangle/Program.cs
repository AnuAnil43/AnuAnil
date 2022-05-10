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
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        string result = new String ('O',height);
        string result1 = new String ('O',width);
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
        Console.WriteLine(result1);
    }
}
