using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesOOP 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Does this template work?");
            Square squareone = new Square();
            Console.WriteLine(squareone.numberOfSides);
            Console.WriteLine(squareone.getPerimeter());
            //Console.WriteLine(squareone.sideLength.get());
        }
    }
    
}

