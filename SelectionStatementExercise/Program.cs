namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Set Random and set the favorite number
            Random r = new Random();
            var favNumber = r.Next(1, 1000); // Generates a random number between 1 and 999

            //Track if the user has guessed correctly
            bool guessedCorrectly = false;

            // Added while loop for them to correctly guess the number
            while (!guessedCorrectly)
            {

                // Prompt the user to guess the favorite number
                Console.WriteLine("Guess my favorite number (between 1 and 999):");

                // Read user input and convert it to an integer
                int userInput;
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    // Check if the user's guess is too low, too high, or correct
                    if (userInput < favNumber)
                    {
                        Console.WriteLine("Too low.");
                    }
                    else if (userInput > favNumber)
                    {
                        Console.WriteLine("Too high.");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!!!");
                    }
                }
                else
                {
                    // Handle the case where the input is not a valid integer
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
        }
    }
}

    
