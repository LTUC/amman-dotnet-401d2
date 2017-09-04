# ![cf](http://i.imgur.com/7v5ASc8.png) Class 03

## Overview
* Introduce students to Arrays. They may/should already have an idea of what arrays are from 201 and 301. This will be a refresher that is specific to c#.
* They will be using arrays to read lines in from an external file.
* Primarily this lecture focuses on reading and writing to an external file. They will be using the System.IO library to achieve this.
* They will be checking if a file exists in a location, create the file if needed, read in the lines (in an array), manipulate/do something with the data, and send/save it back to the file.
* Introduce the 'using' statements. Describe what the using statements do and that they are used for more than in file manipulation. It can also used in DB calls.  The most important part about 'using' statements is that they close the connection when the action is complete.
* This lab will be a bit more advanced than the previous days. At this point they should be comfortable with user input and response. They will be creating a word guess game that saves all possible words to an external location and randomly selects one of those words to be guessed. 


## Learning Objectives

1. The Student will be able to successfully Create, Read, and Update a text file using the System.IO library
1. Student will create an array and use an array to read lines from an external text file application
1. Students will know and understand the purpose of the using statements when opening up a file.


## Lecture Outline

1. Review what we know so far...
   1. Methods
   1. Error Handling
   1. If statements
   1. User Validation

1. Let's talk about file manipulation...
   1. What is File Manipulation
      1. Way to persist data (without a db or with an in-memory option)
   1. How would we access an external file?
      1. What is System.IO
         1.  System IO is a namespace ( ***what is a namespace again?***)
         that allows reading and writing to to files and a data streams along with basic file and directory support
      1. [System.IO](https://msdn.microsoft.com/en-us/library/system.io(v=vs.110).aspx) classes

      1. Set the path in a string: 
         ```csharp 
            string path = @"Full\Path\to\File.txt";
         ```
      1. 

1. **System I.O Library**
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
  
   1. Scenario #2: File Already exists, not i jsut need to find and read it in! 
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

## Readings
1. [Single Dimensional Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays)
1. [File and Stream I/O](https://docs.microsoft.com/en-us/dotnet/standard/io/index)
1. [Write to a file](https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file)
1. [Read to a file](https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-read-and-write-to-a-newly-created-data-file)


## Resources
1. [Copy, Delete, Move Files and Folders](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders)

## Code Challenge 03
Josie Cat has 2 types of plants she would like to plant; cat nip, and mint.
She would like to alternate each of these plants within 5 columns and 5 rows. 

If you have time, using the same number of colums and rows as above, create another garden for Josie Cat that has alternating rows
- The 1st/3rd/5th row are of Carrots
- The 2nd/4th row are of tomatos.

Duration of this Code challenge: 90 minutes