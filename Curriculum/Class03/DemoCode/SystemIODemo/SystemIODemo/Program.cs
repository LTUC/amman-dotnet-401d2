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

            CreateFile();
            //FileAlreadyExists();
            //ReadAFile();
            //UpdateAFile();
            //DeleteAFile();
            //PracticeUsingSplit();
        }

		static void CreateFile()
		{
			string path = "myFile.txt";
            string[] myARray = { "I", "Love", "cats" };

            // first way
            try
			{
				using (StreamWriter sw = new StreamWriter(path))
				{
                    
					try
					{
						sw.Write(myARray);
					}
					catch (Exception e)
					{

						throw;
					}
					finally
					{
						sw.Close();
					}
				}

			}
			catch (FileNotFoundException e)
			{

				throw;
			}


            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    try
            //    {
            //        sw.WriteLine("Hello World!!!!");
            //    }
            //    catch (Exception e)
            //    {

            //        throw;
            //    }
            //    finally
            //    {
            //        sw.Close();
            //    }
            //}
            //// Second Way
            //using (FileStream fs = File.Create(path))
            //{
            //	Byte[] myWords = new UTF8Encoding(true).GetBytes("All of the words!");
            //	fs.Write(myWords, 0, myWords.Length);
            //}
        }

		static void ReadFile()
		{
			string path = "myFile.txt";

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
				for (int i = 0; i < 5; i++)
				{
					sw.WriteLine(i);
				}

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
