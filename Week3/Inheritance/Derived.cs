namespace Inheritance
{
    public class Derived : Base 
    {
        //Fields
        public string derivedString;
        //Constructor
         public Derived()
         {
           this.derivedString = "Derived";
         }
        //Methods

        // Method Overriding is a method that lets us invoke the function/method 
        // of a (base/super) class in another (derived/subclass)
        //Creating a method in the derived class with the same name as the base class

       // Access Modifier Return type Method-Name(Parameters)
        
        public override void Speak() // "override" is required to extend or modify the virtual method 
        {
            Console.WriteLine("I am a Derived type object");
        }
        // All Override members
        //- Provide a new implementation of an inherited method
        //- must have the same signature as the inherited method (must return and accept 
        // the same type)
        //both methods must be virtual or override
        //must NOT use static or virtual to override a method
        public void Speak(string s)
        {
            Console.WriteLine("The speak method was passed:" + s);
        }
    }
}