namespace GameLogicLibrary;

public class GameLogic
{
    private int randomNumber;
    public int RandomNumberGenerator(int minimumNumber, int maximumNumber)
    {
        randomNumber = new Random().Next(minimumNumber, maximumNumber + 1);
        return randomNumber;
    }

    public bool IsGuessCorrect(in int guess)
    {
        return guess == randomNumber;
    }
    public enum Restart
    {
        playAgain,
        exitGame,
        inputError
    }
    public Restart ContinueGame(string response)
    {
        if (response == "Y")
            {
                return Restart.playAgain;
            }
        else if (response == "N")
            {
                return Restart.exitGame;
            }
        
        throw new Exception("I don't understand anything besides Y or N!");
    }
}