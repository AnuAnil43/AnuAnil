class Program  {
    public static void Main(String[] args) {
        string appName = "Number Guess";
        string appVersion = "1.0.0";
        string appAuthor = "Brad Traversy";
        

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("{0}: Version {1} by {2} ", appName, appVersion, appAuthor);

        //Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;


        Console.WriteLine("What is your name?");
        Console.ForegroundColor = ConsoleColor.Red;


        string? input = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Hello {0}, Let's play a game", input);

        int guess = 0; 
        Console.WriteLine("Enter a number between 1 and 10");
        int guess1 = Convert.ToInt32(Console.ReadLine());

        While(true);
        {
           if (guess1 == 0)
           { 
            Console.WriteLine("Entered number is correct");
           }
           else 
           {
            Console.WriteLine("Entered number is not correct");
           }
        }
    }
}




