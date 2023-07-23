
# Day 4 Key Takeaways

Object Type, Generic, Dynamic, Boxing and Unboxing, Type Castings

## Lessons Learned

### Object Type

- Considered as the root class of C# type system
- Has a set of pre-defined methods ToString(), Equals(), GetHashCode()
- Other types in C# may be upcasted to Object. as they are the direct / indirect inheritance from object class

### Boxing and Unboxing

- Mechanism provided by C# to convert between value type and reference type data
- Boxing is the process of converting a value type to an object class instance
- unboxing is the process of converting object type to its original value type

Example of a code snippet demonstrating the object boxing concept

```csharp

public class MainProgram
{
    public static void Main()
    {
        object genericObject;

        int num = 20;
        genericObject = num; // allowable implicit boxing
        object anotherObject = (object)num; // explicit boxing

        int unboxedValue = (int)genericObject; // accepted type allows explicit unboxing
        bool unboxedBool = (bool)anotherObject // incompatible type would throw InvalidCast Exception

    }
}

```

Please note the last line in the Main() above wouldn't result in compilation error, a runtime exception will occur instead.

### Reference Vs Value, Why should i care?

- Key difference between a reference and a value type data in C# is how they are treated in the computer memory
- A value type store their data in the memory location where the var is declared (*namely: stack*)
- A reference type store a memory address in the stack that points to the location where the actual data is stored. known as heap.
- Commonly, value types in C# are primitives whereas reference type consist of a larger sized data such as string and collections
- The differences mentioned above resulted in reference type having dynamic memory alloc - dealloc.
- This consequence leads to unpredictable and higher memory overhead for reference types. **please take note of this before deciding to use reference type**

### Generics in C

- A feature in C# which allows user to create class, method, or interface that accepts parameter that represent different data types
- Generic is denoted by the `<T>` syntax.
- Generic is a good approach to create something that require universal type parameters as generic can handle reference and value type
- Data type of a passed argument is defined when an instance of the class is created or the method is invoked explicitly

an example of generic implementation as an object placeholder of a method

```csharp

public static bool AreEqual<T>(T value1, T value2)
{
    return value1.Equals(value2);
}

public static Main()
{
    bool sample1 = AreEqual<double>(10.3d, 5.6d) // valid use of method returns false
    bool sample2 = AreEqual<int>(3,3) // valid use of method returns true
}

```

In contrast of using generic, one can use object to achieve this functionality

```csharp
public static bool AreEqual(object value1, object value2)
{
    return value1 == value2
}
```

While allowing different type of passed arguments, the performance of the latter code noticeably hindered by the boxing - unboxing process.

Another approach to achieve this functionality is by introducing method Polymorphism using overloading

```csharp
public static bool AreEqual(int value1, int value2)
{
    return value1 == value2;
}
public static bool AreEqual(string value1, string value2)
{
    return value1 == value2;
}
public static bool AreEqual(double value1, double value2)
{
    return value1 == value2;
}
```

This might resolve the performance issue, but you explicitly against the DRY principle by implementing this code. And for that reason, you should be ashamed and feel bad about yourself.

Also, using generic provides more typesafety rather than the object arguments counterpart.

### Type Casting

- The data conversion process from one data type to another is referred to as typecasting in C#.
- Type casting can be done explicitly or implicitly if some requirements are satisfied.
- Another form of casting can be done based on the inheritance relationship between classes. These concepts are referred to upcast and downcast

#### Implicit Explicit type casting example

```csharp
public static void Main()
{
    int num = 150;
    Type numType = num.GetType();

    double numDouble = num;
    Type numDoubleType = numDouble.GetType();

    decimal numDec = 5678900;
    int x = numDec; // would result in compile time error by data size issues
    bool y = (bool)numDec; // would reuslt in compile time error by incompatibility

    Console.WriteLine($"int num val: {num}"); // 150 valid print
    Console.WriteLine($"int num type: {numType}"); // integer

    Console.WriteLine($"int double val: {numDouble}"); //150 valid print
    Console.WriteLine($"int num val: {num}"); // double

    Console.WriteLine(sizeof(int)); // 4 bytes
    Console.WriteLine(sizeof(double)); // 8 bytes
    Console.WriteLine(sizeof(decimal)); // 16 bytes
}
```

Generally, casting is allowed when different types are compatible to each other. Specifically for implicit casting, the original type should have smaller data size (denoted from the sizeof() function). Explicit casting can be thought of conversion enforcement to allow smaller size types converted to larger size types.

```csharp
public static void Main()
{
    decimal superLargeNumber = 89989898311432560M;

    int forceToFitNumber = (int) superLargeNumber; // allowed explicit cast
    Console.WriteLine(forceToFitNumber); // allowed but may result in broken data
}
```

The explicit casting would result in following:

- allowed casting from larger size data to smaller size data types
- rounding precision errors if the data was to be further computed
- broken data if the value is already defined and forced to fit just like the above example.
- explicit cast would still fail the conversion if the data is incompatible with each other. As for int and string, another method known as parsing can be done.

#### Up cast Down Cast

```csharp
void Main()
{
    Dog dog_1 = new();
    Animal animal_1 = dog_1; // Form of upcasting, implicitly done

    Animal animal_2 = new Dog();
    Dog dog_2 = (Dog)animal_2; // Form of downcasting, explicitly done
    Dog safeDog = animal_2 as Dog; // safer downcasting using as syntax

    Animal animal_3 = new Animal();
    Dog dog_3 = (Dog)animal_3;  // Fails and considered as mismatched conversion type
}

class Animal
{

    // some fields and methods

}

class Dog : Animal
{
    // some fields and methods
}
```

#### Upcasting

- The conversion of a derived class object to its base class object
- Considered implicit cast
- The derived object class shall be treated as the base class during the upcast
- Any methods or fields that is extended from its base class and exclusive only to the derived class wouldn't be able to be accessed after upcasting
- Overriden virtual methods from the base class could still be accessed, but would behave according to the definition stated in the derived class

#### downcasting

- The conversion of a base class object to its derived class counterpart
- Requires explicit casting as the process may result information loss when there is a class mismatch.
- Allows the downcasted object to access the overriden version of its virtual method and extension methods that is exclusive to the child class

Explicit downcasting would still fail if we want to construct a derived class instance such as `Dog dog = (dog) animal` assuming that `animal` is an instance of a parent class. The failure would detected only after compilation by InvalidCast Exception. To prevent the exception from occuring, we can use the **`as`** syntax.

```csharp

Animal animal_2 = new Dog();
Animal animal_3 = new Animal();

Dog doggo_2 = animal_2 as Dog; // succesfull downcast
Dog doggo_3 = animal_3 as Dog; // disallowed downcast results in null assignment

```
