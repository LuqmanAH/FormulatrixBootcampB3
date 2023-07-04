// See https://aka.ms/new-console-template for more information
using Planetarium;

namespace Galaxy;
class program
{
    static void Main()
    {
        Planet Earth = new Planet("Earth", "IntraSolar");
        Planet Mercury = new Planet("Mercury", "Dwarf");
        Planet Jupyter = new Planet("Jupyter", "GasGiant");
        Planet X56B8E = new Planet("X56B8E", "ExtraSolar");

        Console.WriteLine();

        Earth.PlanetOrbit();
        Mercury.PlanetOrbit();

        Console.WriteLine();

        Earth.Populate("Humans");
        Mercury.Populate("Aliens");

        Console.WriteLine();

        Mercury.DoomsDay();
        Mercury.PlanetOrbit();

        Console.WriteLine();

        Earth.PlanetDensity = 340;
        Earth.PlanetTemperature = 25;

        Jupyter.PlanetDensity = 330;
        Jupyter.PlanetTemperature = 35;

        Mercury.PlanetDensity = 320;
        Mercury.PlanetTemperature = 60;
        Console.WriteLine();
        Console.WriteLine("Is Earth Liveable?");
        Console.WriteLine(Earth.IsLifeSupporting());
        // Console.WriteLine();
        Console.WriteLine("Is Jupyter Liveable?");
        Console.WriteLine(Jupyter.IsLifeSupporting());
        // Console.WriteLine();
        Console.WriteLine("Is Mercury Liveable?");
        Console.WriteLine(Mercury.IsLifeSupporting());

    }

}