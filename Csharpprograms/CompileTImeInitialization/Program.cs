// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System; 
namespace CompileTimeInitialization {
    class Geeks {
        int y = 1;
        public static void Main() {
        int x = 32; 
        Console.WriteLine("The value of x is " +x);
        Geeks gfg = new Geeks();
        Console.WriteLine("The value of y is " +gfg.y);
        }
    }
}