using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user for the number of questions.
                Console.WriteLine("Please enter the number of question(s): ");
                int NumberOfQuestions = int.Parse(Console.ReadLine());

                // Declare an array to hold the question(s).
                string[] Questions = new string[NumberOfQuestions];

                // Iterate for the number of questions.
                for (int x = 0; x < NumberOfQuestions; x++)
                {
                    Console.WriteLine($"Enter question number {x + 1}: ");
                    Questions[x] = Console.ReadLine();
                }

                // Display the question(s) entered.
                Console.WriteLine($"\nQuestions eneterd: \n");

                // Print all the questions.
                for (int x = 0; x < NumberOfQuestions; x++)
                {
                    Console.WriteLine($"Question {x + 1}: {Questions[x]}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Message: {ex.Message}");
            }
        }
    }
}
