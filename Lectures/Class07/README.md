![cf](http://i.imgur.com/7v5ASc8.png) Lab 7 : Collections
=====================================

## Overview:
1. Review the coding challenge from the previous day, this will directly tie into today's lecture.
2. We will go over both generic and non-generic, but they will be implementing their own generic collection as their lab assignment. 

## Learning Objectives
1.The student will understand and implement their own enums into their programs and classes.
1. The student will be able to identify and implement their own generic collection.
 
## Lecture Outline

### Enums

1. What are enums?
   1. Enumeration types ("also called enums"), provide an efficient way to define a set of named integral constants that may be assigned to a variable. 

        ```csharp
            enum Days 
            { 
                Sunday,
                Monday, 
                Tuesday, 
                Wednesday, 
                ]Thursday, 
                Friday, 
                Saturday 
            };

            enum Months : byte 
            { 
                Jan, 
                Feb, 
                Mar, 
                Apr, 
                May, 
                Jun, 
                Jul, 
                Aug, 
                Sep, 
                Oct, 
                Nov, 
                Dec 
            }; 


        ```
        - Count starts at 0, if you do not specify a value. 
        - default type of enum is int, but you can specify alt with a :type (such as byte);

            ```csharp
            Days today = Days.Monday;  
            int dayNumber =(int)today;  
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);  

            Months thisMonth = Months.Dec;  
            byte monthNumber = (byte)thisMonth;  
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);  

            // Output:  
            // Monday is day number #1.  
            // Dec is month number #11.  

            ```

            - You can create and set your custom values

            ```csharp
            enum MachineState
            {
                PowerOff = 0,
                Running = 5,
                Sleeping = 10,
                Hibernating = Sleeping + 5
            }

            ```

### Collections

There are two ways to crate and manage a group of related objects
    1. Create an array of objects
    2. creating a collection of objects

1. What is a collection?
   1. Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change. For some collections, you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key.
A collection is a class, so you must declare an instance of the class before you can add elements to that collection.

2. If your collection contains elements of only one data type, you can use a Generic. 

#### Generics
   1. One type of generic collection is a List<.T>; 
   2. Example of a List:

        ```csharp 
        var princesses = new List<string>();

        princesses.Add("Snow White");
        princesses.Add("Cinderella");
        princesses.Add("Aurora");
        princesses.Add("Repunzel");
        princesses.Add("Ariel");

        foreach(var princess in princesses)
        {
            Console.WriteLine($"Princess: {princess}");
        }


        ```

        -using a `foreach` loop to iterate through a list once items have been added

        ```csharp
        var princes = new List<string>{"Eric", "Charming", "Aladdin"};

        foreach(var p in prince)
                {
                    Console.WriteLine($"Prince: {p}");
                }


        ```
        - This one uses a *collection initializer*



        ```csharp
        var princess = new List<strings> {"Jasmine","Moana","Merida", "Anna", "Elsa"}

        for (var index = 0; index < princess.Count; index++)  
        {  
            Console.Write(princess[index] + " ");  
        } 
        ```

        -Use a `for` loop to iterate through

        ```csharp

        //(same as above)
        princess.Remove("Elsa");  

        // Iterate through the list.  
        foreach (var p in princess)  
        {  
            Console.Write(p + " ");  
        }  

        ```

        - Using the 'Remove` list function

        ```csharp
        var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  

        // Remove odd numbers.  
        for (var index = numbers.Count - 1; index >= 0; index--)  
        {  
            if (numbers[index] % 2 == 1)  
            {  
                // Remove the element by specifying  
                // the zero-based index in the list.  
                numbers.RemoveAt(index);  
            }  
        }  

        // Iterate through the list.  
        // A lambda expression is placed in the ForEach method  
        // of the List(T) object.  
        numbers.ForEach(  
            number => Console.Write(number + " "));  
        // Output: 0 2 4 6 8  
        ```
        -Use a `for` loop by decramenting 
        - Why would you decrament?


1. For the type of elements in the List< T>, you can also define your own class

     ```csharp
        private static void IterateThroughList()  
        {  
            var snowWhiteDwarves = new List<Dwarves>  
                {  
                    new Disney() { Name="Doc", age=400},  
                    new Disney() { Name="Happy", age=25},  
                    new Disney() { Name="Dopey", age=100},  
                    new Disney() { Name="Grumpy", age=53}  
                };  

            foreach (Disney dwarf in snowWhiteDwarves)  
            {  
                Console.WriteLine(snowWhiteDwarves.Name + "  " + snowWhiteDwarves.Age);  
            }  

        }  

        public class Disney  
        {  
            public string Name { get; set; }  
            public int age { get; set; }  
        }  

        ```

#### ***Demo** - Let's create own own Generic Collection (List< T>):*

```csharp

class NumberList<Y> 
    {
        Y[] items = new Y[5];
        int count;
        public void Add(Y item)
        {
            if(count == items.Length)
            {
                Array.Resize( ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        public IEnumerator<Y> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NumberList<int> numberList = new NumberList<int>();

            numberList.Add(10);
            numberList.Add(15);
            numberList.Add(25);
            numberList.Add(28);

            foreach (int i in numberList)
            {

            }
        }

```


  - What is `GetEnumerator()`?
      - You need your class iterate through with a for loop. 

- Foreach does not requires Ienumerable
- only requires a Ienumerator GetEnumerator();

- *Enumerable* - means it can be iterated through
- *Enumerator* - that actual 'thing' that walkthroughs and sequences through the list


```csharp
class NumberList<Y> : IEnumerable<T>
    {
        Y[] items = new Y[5];
        int count;
        public void Add(Y item)
        {
            if(count == items.Length)
            {
                Array.Resize( ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        public IEnumerator<Y> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

    }

  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NumberList<int> numberList = new NumberList<int>() {4, 8, 15, 16, 23, 42};

            foreach (int i in numberList)
            {

            }
        }

```

-By adding the implementation of IEnumerable, it allows your program to support the 'new' syntax.
- As the other example before this shows, it is not necesarily required, but good practice
- When you build the above example, when you imeplemt the interface, have VS auto implement it for you.
- Because the interface of IEnumerable requires the non-generic GetEnumerator, VS will auto add what is missing. Here is the after result:

```csharp
   class NumberList<Y> : IEnumerable<Y>
    {
        Y[] items = new Y[5];
        int count;
        public void Add(Y item)
        {
            if(count == items.Length)
            {
                Array.Resize( ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        public IEnumerator<Y> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        //This is new, but GetEnumerator will call the Generic GetEnumerator above.

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Can create Custom Enumerator Method here that the GetEnumerator returns
    }

```

**Yield Return**

-You use a `yield return` statement to return each element one at a time.
- 'pauses' and returns the next value

**Yield Break**

You use a `yield break` statement to end an iteration
    -Clean way to end a loop from executing

**There is much more to `yield return` and `yield break` then what we may go over. 
  - if there is time in class we can go over the details of whats 'under the hood' 
   of the `yield` statements, or just direct the student to do some self research on it. 



### Generics vs. Non-Generics

#### Generics
- List< T>
- Dictionary< T>
- SortedList< T>
- Queue< T>
- IEnumerable< T>
- IList< T>
- Collection< T>
- LinkedList< T>

#### Non-Generics
*are not really used much anymore*

- ArrayList
- Hastable
- SortedList
- Queue
- Stack
- IEnumerable
- ICollection
- 

     
## Coding Challenge
Implement a singly linked list
- Find Middle of Linked List

-Using your "data-structures" repository
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas