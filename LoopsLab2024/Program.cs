//Use a do-while loop to output "Hello, World!" in a loop.
//Each time you output "Hello, World!" ask the user whether they
//would like to continue.

//bool choice = true;

//do
//{
//    Console.WriteLine("Hello World!");
//    Console.Write("\nWould you like to continue (y/n)? ");
//    string userAnswer = Console.ReadLine().ToUpper();

//    if (userAnswer == "N") {
//        Console.WriteLine("\nBye!");
//        choice = false;
//    }
//} while (choice);


//Prompt the user for a number.
//Use a for loop to output all the numbers from that number to 0.
//After that loop finishes, use another loop to output all the numbers
//from 0 to that number.


//while (true)
//{
//    Console.Write("Please enter a number: ");

//if (int.TryParse(Console.ReadLine(), out int parsedAnswer))
//{
//    for (int i = parsedAnswer; i >= 0; i--)
//    {
//        Console.Write(i + " ");
//    }

//    Console.WriteLine();

//    for (int i = 0; i <= parsedAnswer; i++)
//    {
//        Console.Write(i + " ");
//    }

//    break;
//}
//else
//{
//    Console.WriteLine("That's not a number! Try again!");
//    Thread.Sleep(1500);
//    Console.Clear();
//}
//}

//A door has a keypad entry. The combination to get in is 13579.
//Write a while loop (not a do while loop)
//that asks the user to enter a key code.
//The loop will repeat as long as the user enters the wrong code.
//After the user enters the correct code, the program
//will print out a welcome message.

//bool locked = true;

//while (locked)
//{
//    Console.Write("Please enter the door code: ");
//    int userInput = int.Parse(Console.ReadLine());

//    if (userInput == 13579)
//    {
//        Console.WriteLine("Correct. Welcome home!");
//        locked = false;
//    }
//    else
//    {
//        Console.WriteLine("Please try again.");
//    }
//}

//Continue the previous exercise, but now add a limited number of tries,
//say 5. After 5 unsuccessful attempts, the loop ends,
//but instead of printing a welcome message,
//it prints a message warning that there were too many incorrect attempts.
//(But if the user entered the correct number,
//it will still print the welcome message as before.)

//bool locked = true;
//int attempts = 0;

//while (attempts < 5)
//{
//    Console.Write("Please enter the door code: ");
//    if (int.TryParse(Console.ReadLine(), out int userInput))
//    {
//        attempts++;

//        if (userInput == 13579)
//        {
//            Console.WriteLine("Correct. Welcome home!");
//            locked = false;
//        }
//        else
//        {
//            Console.WriteLine("Please try again. - " + attempts + " attempt(s) used. Aborting after 5.");
//        }
//    }
//    else
//    {
//        attempts++;
//        Console.WriteLine("Invalid input. Please enter a number. - " + attempts + " attempt(s) used. Aborting after 5.");

//    }
//}

//if (attempts == 5)
//{
//    Console.WriteLine("TOO MANY ATTEMPTS. ABORTING");
//}

//repeat the same exercise as the previous,
//except this time implement it with a do while loop.


//bool locked = true;
//int attempts = 0;

//do
//{
  

//    Console.Write("Please enter the door code: ");
//    if (int.TryParse(Console.ReadLine(), out int userInput))
//    {
//        attempts++;

//        if (userInput == 13579)
//        {
//            Console.WriteLine("Correct. Welcome home");
//            locked = false;
//        }
//        else
//        {
//            Console.WriteLine("Incorrect. " + attempts + " attempts now used. Lock out after 5 attempts");
//        }
//    }
//    else
//    {
//        attempts++;
//        Console.WriteLine("Invalid input. " + attempts + " attempts now used. Lock out after 5 attempts");
        
//    }

//    if (attempts == 5)
//    {
//        Console.WriteLine("5 ATTEMPTS HAVE BEEN TRIED. LOCK OUT.");
//    }

//    if (attempts == 5)
//    {
//        Console.WriteLine("5 ATTEMPTS HAVE BEEN TRIED. LOCK OUT.");
//        break;

//    }

//} while (locked = true);