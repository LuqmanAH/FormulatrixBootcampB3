
# Day 5 Key Takeaways

class as reference type, struct as value type, Immutability

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

### Type Mutability

A data type in C# is either mutable or immutable. Mutable types allow dynamic changes of values contained within the type.

One instance of this type is allowed to be modified or reassigned to a new value in its lifetime without the need to create new instances.

A custom class and many of collection object members are considered as mutable.

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

Person person = new Person { Name = "John", Age = 30 };
person.Name = "Jane"; // Mutable: Changing the name property
person.Age = 31;      // Mutable: Changing the age property
```

Immutable types on the other hand, would need to create a new instance that contains the updated value of the previous instance. for example:

```csharp
int x = 10;
x = 20; // This creates a new value (20) and assigns it to the variable x. The original value (10) is not modified.
```

Collection types do not need to do this and thus appending items is a breeze, and shouldn't hinder the app performance.

```csharp
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
names[1] = "Alex"; // Modifying the second element of the list from "Bob" to "Alex"
names.Add("David"); // Adding a new element to the list
names.RemoveAt(0); // Removing the first element from the list
```

*Important*

Methods that require concatenation of strings in exhaustive manner means recursive loop of construction and destruction of strings instances to continuously update its value. This is because the string type is immutable

Use StringBuilder class for the for the mutable counterpart to improve app performance
