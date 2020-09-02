using System;

namespace c_letter_remover_practice_T_Ralph
{
    class Program
    {
        static void Main()
        {
            /*
                Title: C# Letter Remover Practice
                Purpose: Receive input string and replace any chosen string
                Doc: https://docs.google.com/document/d/1fwpvIlb5BbEVrMCHLJs-mcUyGCzdaN95qfj1QVhCyTk/edit#heading=h.dk6unz8vhppe
                Author: Tosin Raphael Olaniyi (T-Ralph)
                Last Modified Date: August 12, 2020
            */

            //Greet the user
            Console.WriteLine("  ------- -- -- ------ ------- --------  \n| Welcome to C# Letter Remover Practice |\n  ------- -- -- ------ ------- --------  ");
            Console.WriteLine("-> Enter the Word, then, Enter the Letter and the Program will remove the Letter from the Word");
            Console.WriteLine("-> For multiple Replacement Letters, separate them with commas (Ex: a,b,c,d)");
            Console.WriteLine("-> To exit the Program, enter Letter 'q' for the Word (case insensitive)\n");

            //Run the MainProcess method
            MainProcess();
        }

        static void MainProcess()
        {
            //Declare datatypes
            string word = "";
            string letter = "";

            //Listen for 'q' to exit program using Loop
            while (word.ToLower() != "q")
            {
                //Ask for input
                Console.Write("Enter the Word: ");
                word = Console.ReadLine();

                if (word.ToLower() == "q")
                {
                    ExitProgram(); //Exit the Program
                }
                else
                {
                    //Ask for input
                    Console.Write("Enter the Letter: ");
                    letter = Console.ReadLine();

                    LetterRemover(word.ToLower().Trim(), letter.ToLower().Trim()); //Remove trail & lead spaces, convert to lowercase and Run LetterRemover method
                    MainProcess(); //Run MainProcess method again
                }
            }

            //Trying do-while loop
            /*
            do
            {
                //Ask for input
                Console.Write("Enter the Word: ");
                word = Console.ReadLine();

                if (word.ToLower() == "q")
                {
                    ExitProgram(); //Exit the Program
                }
                else
                {
                    //Ask for input
                    Console.Write("Enter the Letter: ");
                    letter = Console.ReadLine();

                    LetterRemover(word.ToLower().Trim(), letter.ToLower().Trim()); //Remove trail & lead spaces, convert to lowercase and Run LetterRemover method
                    MainProcess(); //Run MainProcess method again
                }
            } while (word.ToLower() != "q");
            */
        }

        static void LetterRemover(string word, string letter)
        {
            //Declare datatype
            string replacedWord = "";
            string interimWord = word;
            string[] letters = letter.Split(",");
            int numberOfReplacements = 0;

            //Loop for multiple replacement letters
            for (int i = 0; i < letters.Length; i++)
            {
                //Remove letter from word using for loop
                for (int j = 0; j < interimWord.Length; j++)
                {
                    if (Convert.ToChar(interimWord[j]) != Convert.ToChar(letters[i]))
                    {
                        replacedWord += interimWord[j]; //Add Replacement Words
                    }
                    else
                    {
                        numberOfReplacements++; //Count Replacements
                    }
                }
                interimWord = replacedWord; //Update the Interim Word
                replacedWord = ""; //Update the Replaced Word
            }
            replacedWord = interimWord; //Set back the Replaced Word

            Console.WriteLine($"Replaced Word: {replacedWord}"); //Display Replaced Word
            Console.WriteLine($"# of Replacements: {numberOfReplacements}\n"); //Display # of Replacements
        }

        static void ExitProgram()
        {
            //Exit the program
            Console.WriteLine("\n  -------------------  \n| Program will exit now |\n| Bye                   |\n -------------------  \n");
            Environment.Exit(0);
        }
    }
}
