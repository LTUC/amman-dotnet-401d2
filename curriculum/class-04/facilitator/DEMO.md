# Demos: Classes and Objects

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

This demo feels like a lecture and is a lot of the "Resource" material repeated. It's important to use this sequence to solidify the core OOP concepts in an organized fashion, by building it out during lecture.

## Demo

### Classes

Create a class with the students driving the model. Things that work well are commonly understood things such as People, Cars, Cups, etc.

When building out a class, you should follow a prescribed order:

1. Properties
1. Constructor
1. Methods

#### Properties

Defined with "getters" and "setters"

1. Auto Generate a few

   ```csharp
   public string Age {get; set; }
   ```

1. Manually create with a "backing field

#### Constructor

- Looks like a method, but it's not.
- Has the same name as the class
- May take params
- May be overloaded

Default Constructor: No Args. This is what you get if you don't define one

```csharp
public Person() { }
```

Build a specific constructor, perhaps as an override. These become required

Note to your students that you can have multiple overrides

```csharp
public Person( string name, string hairColor, int age ) {
  Name=name;
  HairColor=hairColor;
  Age=Age
}
```

#### Methods

Build out a simple method, perhaps one that changes a property of the object, demonstrating that these are "things our instances can do" ...

For Example

```csharp
void GetJob() {
  Money = 180000;
}
```

### Instances

Create some instances of the object, using all means

Manually

```csharp
Person john = new Person();
john.Name="John";
john.Age=52;
```

Using a constructor with args

```csharp
Person john = new Person("John", 52);
```

Using an object inintializer

```csharp
Person john = new Person() { FirstName = "John", Age = 52 };
```

##### Static Properties and Methods

Without "static", methods belong to the instances

```csharp
public string Walk() { isWalking = true; }
john.walk()
// Now, john's "isWalking" property is true
```

With "static", it's a class thing, not an instance thing...

```csharp
public static Feed() { Console.WriteLine("Feeding my people"); }

john.Feed(); // Fails, static methods don't work on instances
Person.Feed(); // Works, but it's a method on "the People class", but not on any one person
```

## Multiple Classes

Now, create another class and connect them.

For example, have a property of one class be an instance of another

- e.g. A book, where the Author is an instance of Person
