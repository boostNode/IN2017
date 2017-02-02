/*
 *  Author: Troy Davis
 *  Project: SumInts (Chapter 5, Programming Exercise 2)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 1, 2017 
 *  Revision: Original
 */

using System;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            // class scope variables
            String strFeedback = "";
            String strInput;
            int intInput;
            int intSumInts = 0;

            // initialize console
            Console.WriteLine("Sum Ints");

            // initiate input loop
            do
            {
                // get user input
                do
                {
                    // get user input
                    Console.WriteLine("\n\t" + strFeedback + "Enter any integer number, 999 to quit:");
                    Console.Write("\n\t\t"); strInput = Console.ReadLine();

                    // validate user input
                    strFeedback = "";
                    if ( ! Int32.TryParse(strInput, out intInput)) // parse input to Int32, handle non-numeric input
                    {
                        strFeedback = "Invalid Input! ";
                    }

                } while ( strFeedback != "" );

                // accumulate inputs
                if( intInput != 999 )
                {
                    intSumInts += intInput;
                }

            } while ( intInput != 999 );

            // provide feedback on sum of integer inputs
            Console.WriteLine("\n\tThe sum of the entered integers is " + intSumInts.ToString() + ".");

            // wait on user to close console
            Console.Write("\n\t"); Console.ReadLine();
        }
    }
}
