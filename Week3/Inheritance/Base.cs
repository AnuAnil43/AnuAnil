namespace Inheritance
{
    public class Base 
    {    
        // Fields
        public string baseString;
        // Constructor
        public Base()
        {
            this.baseString = "Base";
        }
        //Methods
        public virtual void Speak()
        {
            Console.WriteLine("Hello, I am a base type object");
        }
        public virtual void Speak(string s)
        {
            Console.WriteLine("This is the speak method from the base class");
            Console.WriteLine("Speak was passed:" + s);
        }
    }
}