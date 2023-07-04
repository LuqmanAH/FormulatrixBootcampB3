namespace Planetarium;

public class Planet
{
    public string PlanetName{get; private set;}
    private string _planetType;
    public int PlanetDensity{private get; set;}
    public int PlanetTemperature{private get; set;}

    public Planet(string PlanetName, string planetType)
    {
        this.PlanetName = PlanetName;
        this._planetType = planetType;
    }

    public void PlanetOrbit()
    {
        if (this.PlanetName == "Dead Planet :(")
        {
            Console.WriteLine($"I can't do that, i'm a {this.PlanetName}");
        }
        else{
            Console.WriteLine($"Planet {PlanetName} is now orbitting");
        }
    }

    public void DoomsDay()
    {
        Console.WriteLine($"Commencing doomsday to {this.PlanetName}...");
        Console.WriteLine($"{this.PlanetName} name is now Dead Planet");
        this.PlanetName = "Dead Planet :(";
    }

    public bool IsLifeSupporting()
    {
        if (this.PlanetDensity <= 356 && this.PlanetTemperature <= 40 && _planetType != "GasGiant")
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
        Console.WriteLine($"there are {species} living in this {this.PlanetName} now");
    }
}
