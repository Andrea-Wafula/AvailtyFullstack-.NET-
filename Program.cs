using LISPValidator.Domain.Utilities;
using System;

namespace LISPCheckerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome the user to the new application by providing a welcoming note.
            Console.WriteLine("Welcome to the LISP Validaor applicaion");

            //Call the main method of the entire program.  
            ValidateParenthesis(args);

            //This is the end of the application runtime. It notifies the user that the application has been terminated
            Console.WriteLine("Application closed!");

           
            //The argument for this program : USER(1): (* 2 (cos 0) (+ 4 6)).
            //It has been predefined by the administrator in the Properties/Arguments tab of the LISPCheckerConsoleApp.
            //Replaces the "Console.WriteLine("Type in your own words");" phrase for input
            //ValidateParenthesis();
        }

        private static void ValidateParenthesis(string[] LispCodeargs)
        {
            //The new variable 'validator', of type 'ParenthesisValidator' created, takes in a array of strings.
            var validator = new ParenthesisValidator(LispCodeargs);

            //The variable 'P'arenthesisAreValid' calls the main method to the existing variable which executes the method; a list of words/letters being evaluated
            //To identify whether the number of open parenthesis are equal to the number of closed parenthesis.
            var parenthesisAreValid = validator.ValidateParenthesis();

            //The output is decided by the if statement.
            if (parenthesisAreValid)
            {
                Console.WriteLine("LIPS Code Parenthesis validation declared valid");
            }
            else
            {
                Console.WriteLine("LISP Code Parenthesis valdation declared invalid");
            }
        }
    }
}
