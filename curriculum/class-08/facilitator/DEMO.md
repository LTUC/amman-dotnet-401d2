# Demos: Collections and Enums

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

This demo feels like a lecture and is a lot of the "Resource" material repeated. It's important to use this sequence to solidify the core OOP concepts in an organized fashion, by building it out during lecture.

## Enums

The simplest and most obvious example is months and days of the week.

- Demonstrate how you can directly look at an Enum
- Demonstrate how a class can use an Enum to sanitize content
  - Date Class

## Collections

- Lists and Dictionaries
- Create some lists and dictionaries and iterate
- Talk through the `<type>` that you declare as you create them.
- Add to a list both explicitly (`.Add()`) and automatically `{x,x,x}`
- Iterate
- Add to a dictionary
- Iterate
- Delete

## Custom Collections

Building a enumerable list that uses **Generic** types can really cement not only how arrays work under the hood, but how much work the actual `List` collection is doing for us.

Building the Enumerator so that you can do a `foreach` takes some work ... talk through it as you develop it.

Try and write the foreach first, inspect the error and then fix it.

We need to be "enumerable", so we'll bring in the Interface

`yield` is a pause, as it sends the value to the front end

```csharp
class NumberList<T> : IEnumerable

...

public IEnumerator<t> GetEnumerator()
{
  for( int i=0; i < count; i++ )
  {
    // yield break (would stop the loop, not pause and return)
    yield return items[i]
  }
}
```

## Linked Lists

Now that we know about generics, refactor your Linked List implementation in front of the class to showcase how Generics are implemented.

This is a big "ah-ha" moment as it makes the concept real.
