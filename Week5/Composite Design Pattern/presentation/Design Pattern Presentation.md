# Composite Design Pattern

Luqman Al Helmy | FMLX bootcamp B3 | 18/08/2023

[comment]: # (!!!)

## What do they have in common?

[comment]: # (!!!)

![Google ex ceo](media/Manager.webp) <!-- .element: style="height:50vh; max-width:80vw; image-rendering: crisp-edges;" -->

[comment]: # (!!!)

![engineer](media/engineer.jpeg) <!-- .element: style="height:50vh; max-width:80vw; image-rendering: crisp-edges;" -->

[comment]: # (!!!)

They both:

[comment]: # (!!! data-auto-animate)

They both: 
- can be considered as employees

[comment]: # (!!! data-auto-animate)

They both: 
- can be considered as employees
- but the latter must report to the former

Note:
How can we as a client can delegate work to them?

[comment]: # (!!! data-auto-animate)

**two approach:**

[comment]: # (||| data-background-color="cadetblue")

approach 1 : tell **every** engineer to create your requests

[comment]: # (||| data-background-color="cadetblue")

approach 2 : tell **the manager** about our project, and let them do the magic

Note:
which one more time efficient?; now how about this?

[comment]: # (!!! data-background-color="cadetblue")

![without pattern class diag](media/without%20pattern.png) <!-- .element: style="height:50vh; max-width:80vw; image-rendering: crisp-edges;" -->

[comment]: # (!!! data-background-color="cornsilk")

![Composite Pattern](media/with%20pattern.png) <!-- .element: style="height:70vh; max-width:80vw; image-rendering: crisp-edges;" -->

[comment]: # (!!! data-background-color="cornsilk")

Which one more reusable?

[comment]: # (!!! data-background-color="cornsilk")

![Composite Pattern](media/with%20pattern.png) <!-- .element: style="height:70vh; max-width:80vw; image-rendering: crisp-edges;" -->

This implements **Composite Structural Pattern**

[comment]: # (!!! data-background-color="cornsilk")

```cs
public abstract class Employee
{

}

public class Manager : Employee
{
    protected List<Employee> _employeesHandled = new List<Employee>();
}

public class Engineer : Employee
{

}
```

[comment]: # (!!!)

## Pros:
1. Flexibility
2. Uniformity
3. Extensibility
4. Abides OCP
5. Reusability

Note:
Flexible Object Structure: The Composite pattern allows you to create complex structures of objects that can represent part-whole relationships. This provides flexibility in designing and representing hierarchies.

Uniform Treatment: Clients can treat individual objects and compositions of objects uniformly through the common interface provided by the Component class. This simplifies client code and makes it easier to work with complex structures.

Ease of Adding New Elements: Adding new types of elements to the hierarchy is relatively easy. You can create new Leaf or Composite classes that implement the Component interface, without affecting existing classes.

Recursion and Traversal: The pattern encourages recursive processing and traversal of the object structure. This can be useful for operations that need to be performed on the entire hierarchy.

Open-Closed Principle: The Composite pattern follows the Open-Closed Principle, as you can add new types of components without modifying existing code.

Code Reusability: The pattern promotes code reuse, as both Leaf and Composite classes share a common interface and can be used interchangeably in the client code.

[comment]: # (!!!)

## Cons:
1. Added complexity
2. Limited type checking
3. Difficulty