
# Day 2 Key Takeaways

Basic C#: class, attributes, primitive types, naming convention, the `Console.WriteLine`


## Lessons Learned

### Class; The Building Blocks of OOP
A class is the way to tell C# new objects is constructable by defining its following:
- attributes as field
- property
- constructor
- methods
Code example implementing OOP in c sharp:
```csharp
namespace Planetarium;

public class Planet
{
    private string _planetType;
    public string PlanetName{get; private set;}
    public int PlanetDensity{private get; set;}
    public int PlanetTemperature{private get; set;}

    public Planet(string PlanetName, string planetType)
    {
        this.PlanetName = PlanetName;
        _planetType = planetType;
    }

    public void SebutNama()
    {
        Console.WriteLine("I'AM THE MIGHTY " + this.PlanetName);
    }
}
```
Each OOP component in C# is followed by a modifier. In this example the covered modifiers are the `public` and `private` access modifier. Attributes as field are written in camelcase or followed by _ to define either it's a public or private attributes respectively.

the above code snippet has the example of an attribute as field in class declaration `_planetType`. For this example, the attribute refers to a string that would define the type of the planet.

In contrast of attribute, properties are written in pascal case and can be thought of as a method encapsulation for attributes. For example in the code snippet, `PlanetName` is a string that can be read (defined by its public get) and can not be set directly using the expression `Planet.PlanetName = "Mars"`.

Constructor `ctor` is a method that returns an instance of the class. The instance should reside in a variable and be provided with the required parameters. for this example, the `ctor` of Planet class requires 2 strings as parameter. As such, the creation of an instance can be done using the following syntax
```csharp
Planet earth = new ("Earth", "Intrasolar");
```
This will create the instance of a planet class inside the earth variable with the passsed parameters. C# compiler will provide you with a default empty `ctor` if you don't define any constructor.

Methods can be thought of as a function that defines the capability of the class. For instance, this Planet class has the void method of `SebutNama` which will not return any value and write the defined string in the console terminal. you can invoke a method by this syntax:
```csharp
earth.SebutNama();
```
using the previously created instance of earth, the line of code will write the planet name concatenated with the string.

### C# primitives
Some example of C# primitive data types:
- int32
- char
- float
- decimal
- double
- boolean
