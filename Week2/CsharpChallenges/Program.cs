//aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Declare a string variable and an integer variable but don't assign values to them.
  string var ; 
  int v ;
//Print to the console “Please enter your message and press enter”.
  Console.WriteLine("Please enter your message and press enter");
//Get a string from the user. We are not worried about input validation right now
//so if your user inputs unexpected values, your program will give unexpected results.

   string user_input = Console.ReadLine();
//The user will enter their message.
   Console.WriteLine("The string variable is :" + user_input);
//Assign that entered string to the string variable which you declared initially.
  //string user_input =var;
//Print to the console "Please enter a number LESS THAN the length of your string and press enter".
   Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
   v = Console.ReadLine();
   Console.WriteLine("The entered number is :" +v);
//Assign that entered string to the int variable which you declared initially. 
// int v = integer.parseInt(var);
//Remember to parse the input to an int.
//Declare a char variable but do not assign a value to it.
   // char x;
//Ask the user "For which character should I search in your original message?"
  //  Console.WriteLine("For which character should I search in your original message?");
//Same the user input to the char variable. **remember we are not validating 
//user input at this time so is the letter (char value) isn't in the message, 
//you won't be able to find it.
   // char x = char.Parse(user_input);
//Ask the user for their first name and save it to a string variable.
   Console.WriteLine("Enter your first name ");
   user_input = Console.ReadLine();
//Ask the user for their last name and save it to a variable.
   Console.WriteLine("Enter your last name ");
   var = Console.ReadLine();
//Print to the console a concatination of the users first and last name.
   string Name = user_input + var;
   Console.WriteLine(Name);
//Print to the console the users initials
 // Console.WriteLine(+user_input);
 // Console.WriteLine(+var);
//Print to the console the users first name and the first two letters of their last name.
  Console.WriteLine("User's first name is :" +user_input);
  Console.WriteLine("The first two letters of last name is :" +var.Substring(0,2));
//Print the length of the users last name to the console.
// Console.WriteLine("The length of users last name is :" +var.Length); 
