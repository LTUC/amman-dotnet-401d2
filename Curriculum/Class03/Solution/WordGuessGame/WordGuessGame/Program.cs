using System;
using System.IO;
using System.Linq;

namespace WordGuessGame
{
    class Program
    {
        static string path = @"..\..\..\Words.txt";

        /// <summary>
        /// Main Method and main point of entry for the program
        /// </summary>
        static void Main()
        {
            string[] initialWords = new string[] { "Cat", "Dog", "Coffee", "Puppy", "Kitties" };

            WriteFullFile(initialWords);
            Console.WriteLine("Welcome to my Word Guess Game!");
            Interface();
        }

        /// <summary>
        /// User interface for user to select options on playing the game
        /// </summary>
        private static void Interface()
        {
            bool complete = false;
            while (!complete)
            {
                int number;
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Start a Game");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Exit");

                Int32.TryParse(Console.ReadLine(), out number);

                switch (number)
                {
                    case 1:
                        PlayGame();
                        break;
                    case 2:
                        ModifyWords();
                        break;
                    case 3:
                        complete = true;
                        Environment.Exit(0);
                        break;
                }
            }

        }

        /// <summary>
        /// User interface to manipulate the word bank
        /// </summary>
        static void ModifyWords()
        {
            bool iscomplete = false;
            while (!iscomplete)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View all Words");
                Console.WriteLine("2. Add a Word");
                Console.WriteLine("3. Delete a Word");
                Console.WriteLine("4. Back to Main Menu");

                int number;

                Int32.TryParse(Console.ReadLine(), out number);

                switch (number)
                {
                    case 1:
                        foreach (string word in GetWords())
                        {
                            Console.WriteLine(word);
                        }
                        break;
                    case 2:
                        AddWord();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("What word would you like to remove?");
                        string answer = Console.ReadLine();
                        DeleteWords(answer);

                        break;
                    case 4:
                        iscomplete = true;
                        Interface();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, Try again");
                        Console.Clear();
                        break;
                }
            }



        }

        /// <summary>
        /// writes words to the specified file
        /// </summary>
        /// <param name="words">the array of words that need to be written to the designated file</param>
        static void WriteFullFile(string[] words)
        {
            using (StreamWriter fs = new StreamWriter(path))
            {
                try
                {
                    foreach (string t in words)
                    {
                        fs.WriteLine(t);
                    }
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// retrieve all the words from the designated saved file
        /// </summary>
        /// <returns>an array of the words saved in the file</returns>
        static string[] GetWords()
        {
            string[] allWords;
            
            
            allWords = File.ReadAllLines(path);
            return allWords;
        }

        /// <summary>
        /// Add a new word to the word bank
        /// </summary>
        static void AddWord()
        {
            Console.WriteLine("What word would you like to add?");

            string word = Console.ReadLine();
            string[] checkWords = GetWords();

            foreach (string item in checkWords)
            {
                if (string.Equals(item, word, StringComparison.CurrentCultureIgnoreCase))
                {
                    return;
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(word);
            }
        }

        /// <summary>
        /// delete a specific word from the word bank
        /// </summary>
        /// <param name="word"></param>
        static void DeleteWords(string word)
        {
            string[] checkWords = GetWords();
            string[] temparray = new string[GetWords().Length];

            int counter = 0;
            for (int ii = 0; ii < checkWords.Length; ii++)
            {
                string item = checkWords[ii];
                if (!string.Equals(item, word, StringComparison.CurrentCultureIgnoreCase))
                {
                    //TODO: Fix Exception for if word doesn't exist
                    temparray[counter] = checkWords[ii];
                    counter++;
                }
            }

            WriteFullFile(temparray);
            Console.WriteLine("Word successfully removed!");
        }

        /// <summary>
        /// Activate the word guess game
        /// </summary>

        static void PlayGame()
        {
            Random random = new Random();
            int number = random.Next(0, GetWords().Length);
            string guessedLetters = "";
            string mysteryWord = GetWords()[number];
            string[] displayWord = new string[mysteryWord.Length];

            for (int i = 0; i < mysteryWord.Length; i++)
            {
                displayWord[i] = " _ ";
            }

            foreach (string t in displayWord)
            {
                Console.Write(t);
            }

            Console.WriteLine();

            bool solved = false;
            while (!solved)
            {
                Console.WriteLine("Guess a Letter");
                string letter = Console.ReadLine();

                if (letter != null && (mysteryWord.ToLower().Contains(letter.ToLower()) && !guessedLetters.Contains(letter)))
                {
                    for (int i = 0; i < mysteryWord.Length; i++)
                    {
                        if (mysteryWord[i].ToString().ToLower() == letter)
                        {
                            displayWord[i] = letter;
                            guessedLetters += letter;
                        }
                    }
                }

                for (int i = 0; i < displayWord.Length; i++)
                {
                    if (i == displayWord.Length - 1)
                    {
                        Console.WriteLine(displayWord[i]);
                    }
                    else
                    {
                        Console.Write(displayWord[i]);
                    }
                }

                Console.WriteLine($"Guessed letters are: {guessedLetters}");

                if (!displayWord.Contains(" _ "))
                {
                    solved = true;
                }

            }
            Console.WriteLine("Congratulations! You solved it! ");
            Console.WriteLine();
        }
    }


}
