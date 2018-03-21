# File Manipulation

Sometimes we need to manipulate an external file. C# offers options
within the language to allow this flexibility. One of the libraries that it 
offers is called System.IO. 


## What is System.IO

System.IO is an available library through .NET that allows for reading and writing
to files and data streams. 

The *I* stands for Input
The *O* stands for Output

## File Class

### Writing a File
There will be times, where we will need to write to an external file. This can be done
by using the SystemIO.File.WriteAllText() method. This Method takes in 2 arguements
first being the file path, and the second the string/information to write. 

```csharp
string myInfo = "I want to write all of this to a file";
File.WriteAllText("/path/to/file.txt", myInfo);
```

You can also send an arary to the `File.WriteAllLines()` method to write from an araay.
When you write from an array, each index is it's own line. 

```csharp
string[] myArray = new string[2];
myArray[0] = "My first line of information";
myArray[1] = "My second line of information";

File.WriteAllText("/path/to/file.txt",myArray);

```

### Reading a File

If you want to read contents of a file into a program, you can use the `File.ReadAllText()` method.
This method takes in just one arguement, the file that you wish to consuem. 

```csharp
string myFile = File.ReadAllText("/path/to/file.txt");

```

If you want to read all the contents of a file into an arary, you can do so with 
the `File.ReadAllLines()` method. This also only takes in one arguement, the file that you wish to consume. 

```csharp
string[] myFile = File.ReadAllLines("/path/to/file.txt");

```

#### Writing/Reading to a CSV

Within the File Class, you are not restricted to just text files, it is possible to expand
it out to csv files as well. The most important part about csv files is to note that each piece of data 
is separated by a comma. You must also note line endings by noting a '\n'. This indicates to start the next column 
of the csv. 

So what does this look like? Here is a code example of reading/writing to a csv:

```csharp
string catInformation = "Name,Age\n";
catInformation = "Belle,6\n";
catInformation = "Josie,6\n";

File.WriteAllText("/path/to/file.csv", catInformation);

string[] catNames = File.ReadAllLines(/path/to/file.csv); 

for(int i = 1; i < catNames.Length; index++)
{
	string fields = catNames[i].Split(',');
	string name = fields[0];
	int age = Convert.ToInt32(fields[1]);
	Console.WriteLine($"Name: {name} Age: {age}");
}

```
## Text Based Files
If you want to have more control over your reading and writing, there is a way to do so in text based files using the FileStream. 

When using FileStream, we are essentially working with individual bytes, which can sometimes get complicated. It is much easier to wrap the FileStream into
a StreamWriter that can work directly with strings, ints, and other types within the write method. 

### Writing a file

When working with the write method, we need to create a new StreamWriter and then conclude our action with a closed connection. Below is an example:

```csharp

FileStream filestream = File.OpenWrite("/path/to/file.txt") // OpenWrite returns a FileStream Object
StreamWriter writer = new StreamWriter(filestream);

writer.Write(3);
writer.Write("Hello");

writer.Close();

```

Let's look at the stream a little closer....

## Stream

- A stream is a sort of pipeline or channel of bytes flowing through your program.
- A stream is an object, and like all objects streams have data and methods. the methods allow you to 
perform actions such as opening, closing, and flushing (clearing) the stream. 

- Most streams flow in only one direction. Each stream is either an input or output stream. 
- You may even open several streams at once to read a file (input stream), seperate the data from valid/invalid (2 output streams), 

1. *StreamReader* - Text input from a file
2. *StreamWriter* - text output to a file
3. *FileStream* -  used alone for bytes with either StreamReader and StreamWriter for text. 
used for either input or output to a file. 
 
   1. Create an external text file
      1. Declare where your file will be created

		 ```csharp 
		   string path = @"Full\Path\to\File.txt";
		 ```
      1. if the file doesn't exists...let's create it:

         ```csharp
           using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("List of Words in File");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
         ```

            1. let's break down this code snippet
               1.  First off - What is this 'using' statement
                   1. it is a statement that forces the `Dispose` to be called - even if an exception is hit.
               1. When using a 'using' statement, you establish a connection to something (db, file, etc...), and do something with that connection.
               1. in this case, we are creating a txt file from the path noted, and writing to the file with a message.
               1. `Write()` is a class within the Filestream Class within System.IO
  
   1. Scenario #2: File Already exists, not i just need to find and read it in! 
      1. Read the file in
       ```csharp
        using (StreamReader sr = File.OpenText(path))
        {
           string s = "";
           while ((s = sr.ReadLine()) != null)
           {
             Console.WriteLine(s);
            }
        }
         ```
      -OR-
    ```csharp
        string[] worrds = File.ReadAllLines(path);
    ```

      1. Write to the end of a file:
           ```csharp
                    using (StreamWriter sw = File.AppendText(path))
                    {
                      sw.WriteLine(word);
                    }
         ```    
      1. Delete a file:
         ```csharp
            File.Delete(completePath);
            ```
      1. Copy a file from one location to another
         ```csharp
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath =  @"C:\Users\Public\TestFolder\SubDir";

             // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
           ```

          ```csharp
          // To copy a file to another location and 
         // overwrite the destination file if it already exists.
         System.IO.File.Copy(sourceFile, destFile, true);
         ```

          ```csharp
            
           // Will not overwrite if the destination file already exists.
            File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));

           ```
   
1. **Arrays & Reading File Contents**
   1. Why do we need to use arrays?
   1. `Split()` your file
       1. Read by lihe vs splitting by a deliminator
          1. ``char[] delimiterChars = { ' ', ',', '.', ':', '\t' };``
          
                ```csharp
                string text = "one\ttwo three:four,five six seven";
                string[] words = text.Split(delimiterChars);
                ```
   1. iterate through your array of file contents

    ```csharp
    foreach (string s in words)
    {
        System.Console.WriteLine(s);
    }
    ```


## Binary Files
There are alternative options then to write to text based files. Within the File Class, you have the ability to write to a binary file. 
When the content is in binary format, you will be unable to open it up in a text editor and comprehend the data. 

The advantages of binary files is that they take up less space then text based files and the file is is not readable by humans, allowing your data
 to be semi-protected. 

### Writing a file

Using the FileStream, use `BinaryWriter` instead of `StreamWriter`. 
We will conduct as many Writer files as needed to the file. 

```csharp

FileStream filestream = File.OpenWrite(/path/to/file.txt);
BinaryWriter writer = new BinaryWriter(filestream);

writer.Write(3);
writer.Write("Hello");

writer.Close();

```

We must remember to close the writer when you are completed. 

### Reading a file

When reading in a binary file, you have the abiliyt to use many "Read...." methods. 
Below we are reading in a string or an int. 

We must remember to close the reader when completed. 

```csharp

FileStream filestream = File.OpenWrite(/path/to/file.txt);
BinaryReader reader = new BinaryReader(filestream);

int number = reader.ReadInt32();
int text = reader.ReadString();

reader.Close();

```