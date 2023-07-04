namespace UserInterfaceLibrary;

public class UserInterface
{
    public string? response;
    public void DisplayName(int minimumNumber, int maximumNumber)
    {
        Console.WriteLine($"Guess a number between {minimumNumber} and {maximumNumber}");
    }

    public int GetGuess()
    {
        int guess = Convert.ToInt32(Console.ReadLine());
        return guess;
    }

    public void DisplayFinish(int randomNumber, int guessCount)
    {
        Console.WriteLine($"Actual number: {randomNumber}");
        Console.WriteLine($"You have successfully guessed the number in {guessCount} attempt(s)");
    }

    public string? ExitPrompt()
    {
         Console.WriteLine("Play again? Y/N: ");
         response  = Convert.ToString(Console.ReadLine());
         if (response is not null)
         {
            return response.ToUpper();
         }
         return null;
    }
}