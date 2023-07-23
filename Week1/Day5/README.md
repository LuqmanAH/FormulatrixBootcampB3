
# Day 5 Key Takeaways

class as reference type, struct as value type, interface as a reference vs object as a reference, Immutability

## Lessons Learned

### Overview on Class and Struct Type

#### Class

- Allocated in the heap memory and the variable holds memory address to that object in the heap
- support inheritance
- have constructors and destructors
- typically used for complex data structure, modelling real-world entities, and provide behaviour through props and methods.

Consider the following class

```csharp
public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
```

Has the following implementation in `Main()`

```csharp
public static void Main()
{
    Person parent = new("agus", 45);
    Person child = parent; // variable `child` has a reference type object (Parent class)

    Console.WriteLine(parent.age);
    Console.WriteLine(child.age);

    parent.age = 20; // changes on the parent fields also affects child fields
    Console.WriteLine(parent.age); 
    Console.WriteLine(child.age);
}
```

This is happening because both of the parent and child variables are pointing to the same object in the heap memory. This is done by assigning the child variable to be equal with parent variable.

```csharp
Person child = parent;
```

Both instances only store the memory address in the stack memory that points to the actual object in the heap memory. When the object value is modified through one of the pointer, both instances would still points to the same, modified object in the heap memory

(*wow that was mouthful*)

#### Struct

- Struct instances allocated directly in the stack memory
- Considered as a value type
- More lightweight memory usage in contrast with the class
- do not support inheritance

```csharp
public struct Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
```

if the similar `main()` program is executed but the Person object is now a struct type, the modification that occurs in the parent variable **would not** affect the child variable. This is because the assignment of child to equal with parent implicitly tells the compiler to copy the **actual object value** contained in the struct (name and age) rather than its memory pointer.

So now both of the instances has decoupled values from each other that have independent memory address in the stack