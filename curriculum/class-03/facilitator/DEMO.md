# Demos: File Manipulation / System.IO

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

## Demo

### System.IO

- Start with a .NET Core application
- Create a text file and add some content to it (maybe some comma delimited data)
- Using a custom method for each thing in the demo ...
- Using System.IO, read in the file contents
  - `ReadAllText()`
  - Just use the obvious path to the file. Note that you'll get a bug
  - Where is the file in relation the actual application (.exe)??
    - `../../../` because the .exe and .dll are in the bin folder
  - Now, introduce `string[] = ReadAllLines(file)`
    - Returns an array.
    - You can iterate that with a for loop, or ...
      - You can split it with `String.Join('', contents)`
 - Writing is the same operations, but in reverse.
  - `File.WriteAllLines(array)`
  - `File.WriteAllText(text)`
  - `File.AppendAllInes(array)`

### Streams

- Code a simple example to create a file using the Stream writer.
- The syntax is one thing, but more important is HOW a stream works
- Think TCP, where it's going through a process in chunks, as bytes, and being handled on a lower level.

```charp
// Note that this file has no ../../ ... it'll save where the .dll is!
string path = "file.txt";
string[] words = { "I", "Am", "Cool" };

try {
  using( StreamWriter sw = new StreamWriter(path) )
  {
    sw.Write( String.Join("\n", words));
  }
}
catch( Exception )
{
  throw;
}
finally
{
  // We have to deal with the heap/memory ourselves
  sw.Close();
}
```


## Takeaways

- Difference between Write and Append
- Coding this out modularly, so the students are used to making new methods to do each new operation
- Stream Writer, with `using(){}` statement



