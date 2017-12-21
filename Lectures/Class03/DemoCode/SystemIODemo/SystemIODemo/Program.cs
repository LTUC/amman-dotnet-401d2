using System;
using System.IO;
using System.Text;

namespace SystemIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateAFile();
            //FileAlreadyExists();
            ReadAFile();
            UpdateAFile();
            DeleteAFile();
            PracticeUsingSplit();
        }

        static void CreateAFile()
        {
            // There is more than one way to write a file. 
            // One using StreamWriter, the other way is to use FileStream.
            // First way...
            string path = "MyFile.txt";

            try
            {
                using (StreamWriter fs = new StreamWriter("MyFile.txt"))
                {
                    try
                    {
                        fs.Write("this is my text");
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                    finally
                    {
                        fs.Close();
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {

            }

            // Second Way...
            using (FileStream fs = File.Create(path))
            {
                //Filesstream requires a byte array to send data to a text file. 
                // we have to convert our sentance into a byte array throug hteh utfc encoding.
                Byte[] info = new UTF8Encoding(true).GetBytes("List of Words in File");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

        }

        static void ReadAFile()
        {
            string path = "nope.txt";

            // If the file already exists, all we have to do is read it in.

            //One way....

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine("File was not found....");
            }
            finally
            {
                Console.WriteLine("Process Complete");
            }

            // Second way... 
            try
            {
                string[] worrds = File.ReadAllLines(path);

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
            }


        }

        static void UpdateAFile()
        {
            string path = "MyFile.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Cats");
            }
        }

        static void DeleteAFile()
        {
            string path = "MyFile.txt";

            File.Delete(path);
        }

        static void PracticeUsingSplit()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string text = "one\ttwo three:four,five six seven";
            string[] words = text.Split(delimiterChars);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
            }
        }
    }


}
