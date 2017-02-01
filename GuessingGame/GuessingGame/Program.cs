/*
 *  Author: Troy Davis
 *  Project: Guessing Game (Chapter 4, Programming Exercise 7)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 1, 2017 
 *  Revision: Original
 */

using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // class scope variables
            String strFeedback = "";
            String strGuess;
            int intGuess;
            int intMinRandomNumber = 1;
            int intMaxRandomNumber = 11;
            int intRandomNumber;

            // initialize console
            Console.WriteLine("Guessing Game");
            
            // get user input
            do
            {
                // get user input
                Console.WriteLine("\n\t" + strFeedback + "Enter a number between 1 and 10");
                Console.Write("\n\t\t");  strGuess = Console.ReadLine();
                // validate user input
                strFeedback = "";
                if ( !Int32.TryParse( strGuess, out intGuess ) ) // parse input to Int32, handle non-numeric input
                {
                    strFeedback = "Invalid Input! ";
                }

            } while ( strFeedback != "" );

            // get random number
            Random ranNumberGenerator = new Random();
            intRandomNumber = ranNumberGenerator.Next(intMinRandomNumber,intMaxRandomNumber);

            // check guess against random number, output result
            if( intGuess == intRandomNumber )
            {
                Console.WriteLine("\n\tGreat Job, you guessed correctly!");
            }
            else if( intGuess > intRandomNumber )
            {
                Console.WriteLine("\n\tSorry, that's too high! I was actually thinking of the number " + intRandomNumber.ToString() + ".");
            }
            else
            {
                Console.WriteLine("\n\tSorry, that's too low! I was actually thinking of the number " + intRandomNumber.ToString() + ".");
            }

            // wait on user to close console
            Console.Write("\n\t"); Console.ReadLine();
        }
    }
}
