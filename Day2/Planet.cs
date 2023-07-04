namespace Planetarium;

public class Planet
{
    public string planetName{get; private set;}
    private string _planetType;
    public int planetDensity{private get; set;}
    public int planetTemperature{private get; set;}

    public Planet(string planetName, string planetType)
    {
        this.planetName = planetName;
        this._planetType = planetType;
    }

    public void PlanetOrbit()
    {
        if (this.planetName == "Dead Planet :(")
        {
            Console.WriteLine($"I can't do that, i'm a {this.planetName}");
        }
        else{
            Console.WriteLine($"Planet {planetName} is now orbitting");
        }
    }

    public void DoomsDay()
    {
        Console.WriteLine($"Commencing doomsday to {this.planetName}...");
        Console.WriteLine($"{this.planetName} name is now Dead Planet");
        this.planetName = "Dead Planet :(";
    }

    public bool IsLifeSupporting()
    {
        if (this.planetDensity <= 356 && this.planetTemperature <= 40 && _planetType != "GasGiant")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Populate(string species)
    {
        Console.WriteLine($"there are {species} living in this {this.planetName} now");
    }
}
