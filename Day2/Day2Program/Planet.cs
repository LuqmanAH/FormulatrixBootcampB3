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
        _planetType = planetType;
    }

    public void PlanetOrbit()
    {
        if (PlanetName == "Dead Planet :(")
        {
            Console.WriteLine($"I can't do that, i'm a {PlanetName}");
        }
        else{
            Console.WriteLine($"Planet {PlanetName} is now orbitting");
        }
    }

    public void DoomsDay()
    {
        Console.WriteLine($"Commencing doomsday to {PlanetName}...");
        Console.WriteLine($"{PlanetName} name is now Dead Planet");
        PlanetName = "Dead Planet :(";
    }

    public bool IsLifeSupporting()
    {
        if (PlanetDensity <= 356 && PlanetTemperature <= 40 && _planetType != "GasGiant")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Populate(string species, bool planetStatus)
    {

        if (planetStatus == true)
        {
            Console.WriteLine($"there are {species} living in {PlanetName} now");
        }
        else
        {
            Console.WriteLine($"{PlanetName} is not habitable.");
        }
    }
}
