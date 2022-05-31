// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System; 
namespace  ValueTypeTest 
{
    class GeekForGeeks {
        public static void Main() {
            string a = "Geeks";
            a += "for";
            a = a + "Geeks";
            Console.WriteLine(a);

            object obj; 
            obj = 20; 
            Console.WriteLine(obj);

            Console.WriteLine(obj.GetType());
        }
    }
    
}