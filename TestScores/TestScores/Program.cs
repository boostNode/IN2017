using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            // class scope variables
            String strFeedback = "";
            String strInput;
            int intInput;
            int intNumbScores = 0;
            int intSumScores = 0;
            double dblAverageScore;

            // initialize console
            Console.WriteLine("Test Scores");

            // initiate input loop
            do
            {
                // get user input
                do
                {
                    // get user input
                    Console.WriteLine("\n\t" + strFeedback + "Enter a test score between 0 and 100, 'Q' to quit:");
                    Console.Write("\n\t\t"); strInput = Console.ReadLine();

                    // validate user input
                    strFeedback = "";
                    if ( strInput == "q" ) { strInput = "Q"; }
                    if ( strInput != "Q" ) {
                        if (!Int32.TryParse(strInput, out intInput)) // parse input to Int32, handle non-numeric input
                        {
                            strFeedback = "Invalid Input! ";
                        }
                        else if (intInput < 0 || intInput > 100)
                        {
                            strFeedback = "Invalid Input! ";
                        }
                    }
                    else
                    {
                        intInput = 0;
                    }
                } while (strFeedback != "");

                // accumulate inputs
                if (strInput != "Q")
                {
                    intNumbScores += 1;
                    intSumScores += intInput;
                }

            } while (strInput != "Q");

            // provide feedback on number and average of entered scores
            if (intNumbScores != 0)
            {
                dblAverageScore = (double)intSumScores / (double)intNumbScores;
                if (intNumbScores == 1 )
                {
                    Console.WriteLine("\n\tOne score was entered. The average score is " + dblAverageScore.ToString("N1") + "%");
                }
                else
                {
                    Console.WriteLine("\n\t" + intNumbScores.ToString() + " scores were entered. The average score is " + dblAverageScore.ToString("N1") + "%");
                }
            }
            else
            {
                Console.WriteLine("\n\tNo valid scores entered before quitting!");
            }

            // wait on user to close console
            Console.Write("\n\t"); Console.ReadLine();
        }
    }
}
