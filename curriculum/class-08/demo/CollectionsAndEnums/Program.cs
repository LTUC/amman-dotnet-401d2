using System;
using System.Collections.Generic;
using CollectionsAndEnums.Classes;

namespace EnumsAndCollections
{
  class Program
  {
    static void Main(string[] args)
    {
      EnumExample();
      ListExample();
      DictionaryExample();
      CustomCollectionExample();
    }

    static void EnumExample()
    {
      DayOfTheWeek dow = DayOfTheWeek.Wednesday;
      Console.WriteLine($"Today is {dow}");
      Console.WriteLine($"Todays number is {(int)dow}");
      Console.WriteLine($"Convert to Day of Week { (DayOfWeek)42}");

      Date date = new Date();
      date.DayOfMonth = 15;
      date.Day = DayOfTheWeek.Saturday;
    }

    static void ListExample()
    {
      // "Make a variable called "family" using a List of strings, by creating a new instance of the List Collection, specifying type string"
      List<string> family = new List<string>();
      family.Add("John");
      family.Add("Cathy");
      family.Add("Zach");
      family.Add("Allie");
      family.Add("Rosie");


      foreach (string person in family)
      {
        Console.WriteLine(person);
      }

      List<int> numbers = new List<int>() { 2, 4, 6, 8 };
      foreach (int num in numbers)
      {
        Console.WriteLine($"{num} * {num} is {num * num}");

      }
    }

    static void DictionaryExample()
    {
      Dictionary<int, string> myDictionary = new Dictionary<int, string>();

      myDictionary.Add(1, "Slayer");
      myDictionary.Add(2, "Slipknot");
      myDictionary.Add(3, "Megadeth");
      myDictionary.Add(4, "J Cole");
      myDictionary.Add(5, "Ice-T");
      myDictionary.Add(6, "AbbA");

      myDictionary.TryGetValue(3, out string band);
      Console.WriteLine(band);
      Console.WriteLine(myDictionary[5]);

      Dictionary<string, int> myStuff = new Dictionary<string, int>();
      myStuff.Add("Computers", 3);
      myStuff.Add("Cars", 2);
      myStuff.Add("Guitars", 4);
      Console.WriteLine(myStuff["Cars"]);

      // JS: Object.keys.forEach( key => {} );
      foreach (KeyValuePair<int, string> theBand in myDictionary)
      {
        Console.WriteLine("Key: {0}, Value: {1}", theBand.Key, theBand.Value);
      }
    }

    static void CustomCollectionExample()
    {
      CustomCollection<int> numbers = new CustomCollection<int>();
      numbers.Add(2);
      numbers.Add(4);
      numbers.Add(6);
      numbers.Add(8);
      numbers.Add(10);

      foreach (int number in numbers)
      {
        Console.WriteLine($"The number is {number}");
      }

      CustomCollection<int> ages = new CustomCollection<int>() { 15, 22, 50, 52 };

      foreach (int age in ages)
      {
        Console.WriteLine($"The age is {age}");

      }
    }
  }
}