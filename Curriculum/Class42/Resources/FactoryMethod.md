# Factory Method Design Pattern

## What is it

## Why do we use it

## Demo
1. Create a pizzaStore class
1. create a pizza class
1. Have the following methods present in Pizza
```csharp

        public void Prepare()
        {
            Console.WriteLine($"Preparing the Pizza {Name}");
            foreach(string top in Toppings)
            {
                Console.WriteLine(top);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking the Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the Pizza");
        }

```

	1. Create other pizza classes to inherit from pizzsa
		1. Cheese
		1. Pepperoni
		1. Supreme
1. Create a method that allows the ordering of pizza within the PizzaStore class


```csharp
Pizza OrderPizza(string type)
{
	Pizza pizza = new Pizza();
	if(type.equals("cheese"))
	{
		pizza = new CheesePizza
	}

	pizza.prepare();
	pizza.Bake();
	pizza.Cut();
	pizza.Box();
	
	 return pizza;
}
```

### The problem:
We have to now continually change the orderpizza method and add more if statemetns everytime we add more pizza items to our menu.
the modifiablity on this method is not ideal. 

### Solution
Export all of the "if statement" pizza into an external "createPizza" method.
This method should be located in a new class called "SimplePizzaFactory."
The point of this pizza factory is to create the pizza. We are putting the responsiblity externally to create a pizza. not the order method.

```csharp
   public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            switch (pizzaType)
            {
                case "Cheese":
                    Console.WriteLine("Cheese is on the way");
                    pizza = new CheesePizza();
                    break;
                case "Veggie":
                    Console.WriteLine("Veggie Pizza has been created");
                    pizza = new VeggiePizza();
                    break;
                case "Pepperoni":
                    // Create Pepperoni pizza
                    Console.WriteLine("Pepperoni Pizza has been created");
                    pizza = new PepperoniPizza();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }

```

Factories handle the details of object creation. once we have the SimplePizzaFactory, our orderPizza() method just becomes a client of that object.
Anytime it needs a pizza, it just asks the factory to make it. 

`OrderPizza()` just cares that it gets a pizza that is derived from the Pizza class (or implements the pizza interface) so that it can bake, prepare, cut, and box. 

<br />

PizzaStore should now look like this:

```csharp
SimplePizzaFactory factory;
//PizzaStore gets the facotry passed into it as a constructor
public PizzaStore(SimplePizzaFactory pfactory)
{
	factory = pfactory
}

public Pizza OrderPizza(string type)
{
//Order Pizza now requires the factory to create the pizza for us. 
	pizza = factory.CreatePizza(type);
	
	pizza.prepare();
	pizza.bake();
	pizza.cut();
	pizza.box();
	
	return pizza;
}

```

the simplefactory itself is not a design pattern. more of a best practice. 

We can now craete diffetent factories for diffenet types of stores. For example:

1. Pizza store --> NYPizzaFactory (has it's onw pizza menu')
1. PizzaStore ==> ChicagoPizzaFactory

### Framework for the pizza store
Since we can have more than one pizza store, we should make the pizzastore abstract. and then change the line to

<br /> `pizza = createPizza(type)` in the orderPizza method

<br />

Next, create an abstract method:

//this is our factory 
`abstract Pizza createPizza(string type)`


## factory method

`abstract Product FactoryMethod(string type)`

1. abstract - factory method is abstract so the subclasses are counted on the handle object createion
2. Product - a factory method returns a product that is typicaly used within methods defined in the superclass
3. FactoryMethod - a factory method isolates the client (the code in the superclass like orderPizza()) from know what kind of concrete product is actually crated
4. string type - a factory method may be parameterized (or not) to select among several variations of a product. 


### Pizza Shop
An example of a pizza shop after making the abstract class is like this

```csharp
public class NYPizzaStore : PizzaStore
{
	Pizza CreatePizza(string item)
	{
		if (item.equals("cheese"))
		{
			return NYStyleCheesePeizza
		}
	}

	//Other methods...
}

*NOTE:* That that the orderPizza() method in the superclass has no clue which pizza we are creating. 
it just knows it can prepare, bake, cut, and box i


```

Add onto the pizza class now more properties, and make it abstract.

```csharp
string name
string dough
string sauce
List<string> toppings = 

void prepare()
{
	console.writeline...Ingrediants
}

(add code to other methods.)
```

## Example Main Method

```csharp

public static void Main()
{
	PizzaStore nyStore = new NYPizzaStore()
	PizzaStore chicagoPizzaStore = new ChicagoPizzaStore()

	Pizza pizza = nyStore.orderPizza("cheese")
	console.Writeline(pizza.name)


}

```

## Factory broken down

<!-- Insert Drawing here of Pizza Store and the "class" structure-->

### Creator class

PizzaStore - abstract creator class. it defines an abstract factory method that the subclasses implemt to produce products.
Often, the crator class contains code that depends on an abstract product, which is producted by a subclass. the crate never really knows which concrfete prodcut was produced. 
NYPizzaStore - creatPizza() method is our factory method. it produces the produts. 

### Product class
Pizza - factories proeduce products, and i nthe pizzastore, our product is a pizza
CheesePizza - thse are the concrete products - all the pizzzas that are produced in oru stores. 
...
