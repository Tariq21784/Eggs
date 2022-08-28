//Create a class named Eggs.
//It’s main() method holds an integer variable named numberOfEggs
//to which you will assign a value entered by a user at the keyboard.
//Create a method to which you pass numberOfEggs.
//The method displays the eggs in dozens; 
//for example, 50 eggs is four full dozen(with 2 eggs remaining).
//Save the application as Eggs.cs

using System;
namespace Test
{
    class Eggs
    {
        static void Main(string[] args)
        {
            // integer variable named numberOfEggs
            // user input assigns value
            Console.Write("Enter number of eggs: ");
            int numberOfEggs = int.Parse(Console.ReadLine());
            convertEggsToDozens(numberOfEggs);
            Console.ReadLine();
        }

        // method converts the eggs passing through and displays them into dozens
        static void convertEggsToDozens(int numberOfEggs)
        {
            int dozen = numberOfEggs / 12;
            Console.Write("{0} eggs is {1} full dozen", numberOfEggs, dozen);
            int remaining = numberOfEggs % 12;
            if (remaining != 0)
            {
                Console.Write(" (with {0} eggs remaining).", remaining);
            }
            Console.WriteLine();
        }
    }
}

