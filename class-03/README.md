# Class 03: File Manipulation / System.IO

## Overview

<!-- A few sentences about the day -->

## Class Outline

<!-- Additional Items To Be Added By Instructor -->

## Learning Objectives

### Students will be able to

#### Describe and Define

- What is System IO Library and why we use it
- Define what these file types are: CSV, Text, Binary
- SteamReader
- SteamWriter

#### Execute

- Implement the FileStream
- Create, Read, Update and Delete file using FileStream
- Open and Close a file from an external location

## Notes

### System IO Library

#### Writing a file

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

#### Reading a file

 ```csharp
string[] myFile = File.ReadAllLines("/path/to/file.txt");
```

```csharp
string myFile = File.ReadAllText("/path/to/file.txt");
```

#### Creating a file

(Check out the demo. There are 2 different ways to achieve this!)

#### Deleting a file

To delete a file, just tell the library to delete the location by inputting the path.

```csharp
File.Delete(path);
```
