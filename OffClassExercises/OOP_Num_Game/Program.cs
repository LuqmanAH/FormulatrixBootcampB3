// See https://aka.ms/new-console-template for more information
using GameDataLibrary;
using GameLogicLibrary;
using UserInterfaceLibrary;

/*
TODO: Implement OOP Pillar: Inheritance
TODO: Implement
*/
public class Program
{
    public static void Main()
    {
        GameLogic gameLogic = new();
        UserInterface userInterface = new();
        GameData gameData = new(1, 100);
        bool restart = true;

        while(restart)
        {
            int guess = gameData.guess;
            int guessCount = gameData.guessCount;
            int randomNumber = gameLogic.RandomNumberGenerator(gameData.MinimumNumber, gameData.MaximumNumber);

            while (!gameLogic.IsGuessCorrect(guess))
            {
                userInterface.DisplayName(gameData.MinimumNumber, gameData.MaximumNumber);
                guess = userInterface.GetGuess();
                Console.WriteLine("Guess: " + guess);

                if (guess > randomNumber)
                {
                    Console.WriteLine($"{guess} is too high from the actual number!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine($"{guess} is too low from the actual number!");
                }
                guessCount ++;
            }
            userInterface.DisplayFinish(randomNumber,guessCount);
            string? response = userInterface.ExitPrompt();

            if (response == "Y")
            {
                restart = true;
            }
            else
            {
                restart = false;
            }
        }
    }
}