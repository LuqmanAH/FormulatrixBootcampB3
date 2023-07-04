namespace GameLogicLibrary;

public class GameLogic
{
    private int randomNumber;
    public int RandomNumberGenerator(int minimumNumber, int maximumNumber)
    {
        randomNumber = new Random().Next(minimumNumber, maximumNumber + 1);
        return randomNumber;
    }

    public bool IsGuessCorrect(int guess)
    {
        return guess == randomNumber;
    }
}