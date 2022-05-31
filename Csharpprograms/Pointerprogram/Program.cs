// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System; 
namespace Pointerprogram 
{ 
    class GeeksForGeeks {
        public static void Main() {
            unsafe {
                int n = 10; 
                int* p = &n; 
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}",(int)p);
            }
        }
    }
    
}