namespace CollectionTrials;

public class Player
{
	//* Fixed, but modifiable
	public string PlayerName {get; private set;}
	public int playerLevel;
	private static int _idCounter = 0;
	public static int PlayerID
	{
		get
		{
			return _idCounter;
		}
	}

	//* Optional
	public string? Country {get; private set;}

	public Player()
	{
		_idCounter ++;
		PlayerName = $"Player{PlayerID}";
		playerLevel = 1;
	}

	public void LevelUp()
	{
		playerLevel ++;
	}

	public void ChangeName(string name)
	{
		this.PlayerName = name;
	}

	public void SetCountry(string country)
	{
		this.Country = country;
	}
}