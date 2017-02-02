/*
 *  Author: Troy Davis
 *  Project: Guessing Game 2 (Chapter 5, Programming Exercise 14)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 1, 2017 
 *  Revision: Original
 */

using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            // class scope variables
            String strFeedback = "";
            String strGuess;
            int intGuess;
            int intNumbGuesses = 0;
            int intMinRandomNumber = 1;
            int intMaxRandomNumber = 11;
            int intRandomNumber;
            bool boolFoundAnswer = false;

            // initialize console
            Console.WriteLine("Guessing Game 2");

            // get random number
            Random ranNumberGenerator = new Random();
            intRandomNumber = ranNumberGenerator.Next(intMinRandomNumber, intMaxRandomNumber);

            // initiate guessing loop
            do {

                // get user input
                do
                {
                    // get user input
                    Console.WriteLine("\n\t" + strFeedback + "Enter a number between 1 and 10");
                    Console.Write("\n\t\t"); strGuess = Console.ReadLine();
                    // validate user input
                    strFeedback = "";
                    if (!Int32.TryParse(strGuess, out intGuess)) // parse input to Int32, handle non-numeric input
                    {
                        strFeedback = "Invalid Input! ";
                    }

                } while (strFeedback != "");

                // accumulate guesses
                intNumbGuesses += 1;

                // check guess against random number, output result
                if (intGuess == intRandomNumber)
                {
                    Console.WriteLine("\n\tGreat Job, you guessed correctly in " + intNumbGuesses.ToString() + " attempts!");
                    boolFoundAnswer = true;
                }
                else if (intGuess > intRandomNumber)
                {
                    Console.WriteLine("\n\tSorry, that's too high!");
                }
                else
                {
                    Console.WriteLine("\n\tSorry, that's too low!");
                }

            } while ( boolFoundAnswer == false );

            // wait on user to close console
            Console.Write("\n\t"); Console.ReadLine();
        }
    }
}
