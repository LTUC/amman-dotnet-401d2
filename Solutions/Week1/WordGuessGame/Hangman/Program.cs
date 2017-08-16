using System;
using System.IO;
using System.Text;

namespace WordGuessGame
{

    class Program
    {

        static void Main(string[] args)
        {
            UserInterface();

        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to the Word Guess Game. Please select an option.");

            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. View/Add words");
            Console.WriteLine("3. Exit Game");



            int selection = 0;
            try
            {
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        StartGame();

                        break;
                    case 2:
                        ViewWords();

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    case 4:
                        break;

                }
                Console.Read();

            }
            catch
            {
                Console.WriteLine("Error has occured, please select an option");
                UserInterface();
            }

        }


        public static void ViewWords()
        {
            string path = @"C:\Users\amanda\Desktop\CodeFellows\MyTest.txt";

            try
            {

                Console.WriteLine("Please select an option");

                Console.WriteLine("1. View Words");
                Console.WriteLine("2. Add Word");
                Console.WriteLine("3. Return to Main Menu");

                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        // Open the stream and read it back.
                        using (StreamReader sr = File.OpenText(path))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {

                                string[] lines = File.ReadAllLines(path);
                                Console.WriteLine(s);
                            }

                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        AddAWord();

                        break;
                    case 3:
                        UserInterface();
                        break;
                    default:
                        Console.WriteLine("Invalid Request, Please Try again");
                        Console.WriteLine();
                        ViewWords();
                        break;

                }
                if (!File.Exists(path))
                {

                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("List of Words in File");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }


                Console.WriteLine("Would you like to add a word? y or n?");

                string answer = Console.ReadLine();

                switch (answer.ToLower())
                {
                    case "y":
                        AddAWord();

                        break;
                    case "n":
                        UserInterface();
                        break;
                    default:
                        Console.WriteLine("Invalid Response: Please Try again.");
                        ViewWords();
                        break;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine("Invalid Response: Please Try again.");
                Console.WriteLine();
                ViewWords();

            }


        }


        public static void AddAWord()
        {
            string path = @"C:\Users\amanda\Desktop\CodeFellows\MyTest.txt";


            Console.WriteLine("What word would you like to add?");
            string word = Console.ReadLine();

            //TODO - Confirm that word does not alreayd exist in the File


            Console.WriteLine("You want to add " + word + " to your word library? Y or N?");
            string answer = "";
            try
            {
                answer = Console.ReadLine();



                if (answer.ToLower() == "y")
                {
                    string[] worrds = File.ReadAllLines(path);

                    foreach (string s in worrds)
                    {
                        if (s.ToLower() == word.ToLower())
                        {
                            Console.WriteLine("This Word already exists");
                            ViewWords();
                        }
                     

                    }

                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(word);
                    }

                    Console.WriteLine(string.Format("{0} has been successfully added to the list", word));


                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {

                            string[] lines = File.ReadAllLines(path);
                            Console.WriteLine(s);
                        }

                    }

                }
                else
                {
                    ViewWords();
                }

            }
            catch
            {
                Console.WriteLine("Error has occured");
            }




        }

        public static void StartGame()
        {

            string path = @"C:\Users\amanda\Desktop\CodeFellows\MyTest.txt";


            //randomly pick a word from a text document


            string[] lines = File.ReadAllLines(path);

            Random random = new Random();
            int number = random.Next(0, lines.Length);


            string secretword = lines[number].ToString();
            bool done = false;
            string outline = "";
            string guess = "";
            string correctGuesses = "";
            string incorrect = "";
            int counter = 0;
            string current = "";

            foreach (char i in secretword)
            {
                if (i.ToString() == " ")
                {
                    outline += " ";
                }
                else
                {
                    outline += "_ ";

                }

            }
            Console.WriteLine(outline);

            //While the game is starting
            while (!done)
            {
                //  Console.WriteLine(current);

                counter++;

                Console.WriteLine("Please select a letter");

                //the user's guess is now in the string guess variable.
                guess = Console.ReadLine().ToLower(); //j

                if (secretword.ToLower().Contains(guess))
                {
                    correctGuesses += guess.ToLower();
                    current = ReplaceLetter(correctGuesses, secretword);
                    outline = current;
                }
                else
                {
                    if (!incorrect.Contains(guess))
                    {
                        incorrect += guess;

                        Console.WriteLine("Incorrect Letters Guessed: " + incorrect);

                    }
                    else
                    {
                        Console.WriteLine("You've already guessed that letter. Please Try again");
                    }


                }

                Console.WriteLine(current); // outline is _ _ _ _ _

                if (!outline.Contains("_"))
                {
                    done = true;
                }

            }

            if (done)
            {
                Console.WriteLine("Congratulations! You've guessed the word!");
                Console.WriteLine();
                UserInterface();

            }


        }

        public static string ReplaceLetter(string correctGuesses, string secretWord)
        {
            string currentOutline = "";

            foreach (char x in secretWord)
            {
                if (correctGuesses.Contains(x.ToString().ToLower()))
                {
                    currentOutline += x;

                }
                else if (x.ToString() == " ")
                {
                    currentOutline += " ";
                }
                else
                {
                    currentOutline += "_ ";
                }
            }


            return currentOutline;
        }

    }
}