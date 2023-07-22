
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
- TODO
