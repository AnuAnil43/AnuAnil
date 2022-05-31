// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System; 
namespace ArithmeticOperators {
    class ArithmeticOperators {
        public static void Main() {
            int result; 
            int x = 10, y = 5; 
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulus Operator: " + result);
        }
    }
}