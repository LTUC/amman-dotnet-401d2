using System.IO;

namespace FileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../data.txt";

            // ReadFileText(path);

            // ReadRawFile(path);
            // ReadAllLines(path);
            ReadFileText(path);
            OverWriteTheFileContent(path);
            ReadFileText(path);
        }

        static void ReadFileText(string path)
        {
            string dataFromFile = File.ReadAllText(path);


            Console.WriteLine(dataFromFile);
        }

        static void ReadRawFile(string path)
        {
            byte[] data = File.ReadAllBytes(path);

            foreach (byte b in data)
            {
                Console.WriteLine(b);
            }
        }

        static void ReadAllLines(string path)
        {
           string[] lines =  File.ReadAllLines(path);
            int i = 0;
            foreach (string line in lines)
            {
                Console.WriteLine($"{line} in {i}");
                i++;
            }
        }

        static void OverWriteTheFileContent(string path)
        {
            string newLine = "The is new line added by as";

            File.WriteAllText(path, newLine);
        }

    }
}