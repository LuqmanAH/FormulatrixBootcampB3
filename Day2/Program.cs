// See https://aka.ms/new-console-template for more information
using Planetarium;

namespace Galaxy;
class Program
{
    static void Main()
    {
        Planet earth = new ("earth", "IntraSolar");
        Planet mercury = new ("mercury", "Dwarf");
        Planet jupyter = new ("jupyter", "GasGiant");
        Planet x56B8E = new ("x56B8E", "ExtraSolar");

        Console.WriteLine();

        earth.PlanetOrbit();
        mercury.PlanetOrbit();

        Console.WriteLine();

        bool earthStatus = earth.IsLifeSupporting();
        bool mercuryStatus = mercury.IsLifeSupporting();
        bool jupyterStatus = jupyter.IsLifeSupporting();

        earth.Populate("Humans", earthStatus);
        mercury.Populate("Aliens", mercuryStatus);
        jupyter.Populate("Minotaurs", jupyterStatus);
        Console.WriteLine();

        mercury.DoomsDay();
        mercury.PlanetOrbit();
        Console.WriteLine();

        earth.PlanetDensity = 340;
        earth.PlanetTemperature = 25;

        jupyter.PlanetDensity = 330;
        jupyter.PlanetTemperature = 35;

        mercury.PlanetDensity = 320;
        mercury.PlanetTemperature = 60;

        Console.WriteLine();
        Console.WriteLine("Is earth Habitable?");
        Console.WriteLine(earth.IsLifeSupporting());

        Console.WriteLine("Is jupyter Habitable?");
        Console.WriteLine(jupyter.IsLifeSupporting());

        Console.WriteLine("Is mercury Habitable?");
        Console.WriteLine(mercury.IsLifeSupporting());

        Console.WriteLine("Is X Habitable?");
        Console.WriteLine(x56B8E.IsLifeSupporting());

    }

}