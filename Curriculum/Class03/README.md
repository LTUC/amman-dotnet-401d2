![cf](http://i.imgur.com/7v5ASc8.png) Class 03
=====================================

## Learning Objectives
1. The student will be introduced and implement the FileStream.
2. The student will know how to Create, Read, Update, and Delete file using the FileStream.
3. The student will know how to properly open and close a file from an external location.

## Lecture Outline

### System IO Library
 - What is it
 - Why do we use it

 1. Writing a file

```csharp
string myInfo = "I want to write all of this to a file";
File.WriteAllText("/path/to/file.txt", myInfo);
```


```csharp
string[] myArray = new string[2];
myArray[0] = "My first line of information";
myArray[1] = "My second line of information";

File.WriteAllText("/path/to/file.txt",myArray);

```

 2. Reading a file

 ```csharp
string[] myFile = File.ReadAllLines("/path/to/file.txt");

```

```csharp
string myFile = File.ReadAllText("/path/to/file.txt");

```

 3. Creating a file
 4. Deleting a file


## File Stream
 - What is a stream
	1. StreamReader
	2. StreamWriter

## File Types
- CSV
- Text
- Binary
