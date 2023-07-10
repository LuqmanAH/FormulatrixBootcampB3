namespace GameDataLibrary;

public class GameData
{
    public int MinimumNumber{get; private set;}
    public int MaximumNumber{get; private set;}
    public int guessCount = 0;
    public int guess = 0;
    public bool restart = true;

    public void SetMinimum(int value)
    {
        MinimumNumber = value;
    }
    public void SetMaximum(int value)
    {
        MaximumNumber = value;
    }
    public GameData(int MinimumNumber, int MaximumNumber)
    {
        this.MinimumNumber = MinimumNumber;
        this.MaximumNumber = MaximumNumber;
    }
}