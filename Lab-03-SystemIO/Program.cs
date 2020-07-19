using System;
using System.IO;

namespace Lab_03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {/*
                Challenge1("1 2 3");
                Challenge2Console();
                Challenge3();
                Challenge4(new int[] { 1, 1, 2, 3, 4, 2, 3, 2 });
                Challenge5(new int[] { 10, 15, 5, -9, 30 });
                */
                /*
                Challenge6();
                Challenge7();
                Challenge8();
                */
                Console.WriteLine("Input a sentence");
                string sentence = Console.ReadLine();
                string[] sentences = Challenge9(sentence);
                    string output = "";
                for (int i = 0; i < sentences.Length; i++)
                {
                    output += sentences[i];

                }
                Console.WriteLine(output);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }
        /// <summary>
        /// Multiplies 3 valid numbers;
        /// </summary>
        /// <param name="numbers">Numbers to be multiplied</param>
        /// <returns>Product of the numbers></returns>
        public static int Challenge1(string numbers)
        {
            string[] numbersArray = numbers.Split(' ');

            if (numbersArray.Length < 3)
            {
                return 0;
            }

            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(numbersArray[i], out int result))
                {

                    product *= result;
                }
                else
                {
                    product *= 1;
                }
            }
            return product;
        }
        /// <summary>
        /// Takes a number from the user and prompts the user that many times based on that number and then gets an average of the numbers entered
        /// </summary>
        public static void Challenge2Console()
        {
            Console.WriteLine("Please input a number betwwen 2 and 10");
            string userNumbers = Console.ReadLine();
            if (!int.TryParse(userNumbers, out int result))
            {
                throw new Exception("You did not enter a number, try again");

            }
            else if (result < 2 || result > 10)
            {
                throw new Exception("you either entered a number below 2 or higher than 10, try again");
            }
            else
            {
                int[] numbersArray = new int[result];
                for (int i = 0; i < result; i++)
                {
                    Console.WriteLine($"Please enter a number {i + 1}/{result}");
                    string newNumber = Console.ReadLine();
                    if (int.TryParse(newNumber, out int results))
                    {
                        numbersArray[i] = results;

                    }
                    else
                    {
                        throw new Exception("Invalid number, try again");
                    }
                }
                decimal average = Challenge2(numbersArray);
                Console.WriteLine($"Your average is {average}");

            }
        }
        /// <summary>
        /// Calculates an average from the array received
        /// </summary>
        /// <param name="numbers">is an array of numbers received by the user</param>
        /// <returns>Average of numbers inputted</returns>
        public static decimal Challenge2(int[] numbers)
        {
            decimal total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total /= numbers.Length;
        }
        /// <summary>
        /// Is a diamond shape in the console by Console writeline
        /// </summary>
        static void Challenge3()
        {
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");
            Console.WriteLine(" *******");
            Console.WriteLine("  *****");
            Console.WriteLine("   ***");
            Console.WriteLine("    *");


        }
        /// <summary>
        /// receives an array of numbers and outputs the number that is repeated the most.
        /// </summary>
        /// <param name="numbersArray">is an array of numbers typically given from the user</param>
        /// <returns>Most repeated number in the array</returns>
        public static int Challenge4(int[] numbersArray)
        {
            int count = 0;
            int leadCount = 0;
            int leadNumber = numbersArray[0];
            int numberCounted = numbersArray[0];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                count = 0;
                for (int j = 0; j < numbersArray.Length; j++)
                {

                    if (numbersArray[i] == numbersArray[j])
                    {
                        count += 1;
                        numberCounted = numbersArray[i];
                    }
                }
                if (leadCount < count)
                {
                    leadNumber = numberCounted;
                    leadCount = count;
                }
            }
            return leadNumber;
        }
        /// <summary>
        /// returns the largest number in an array
        /// </summary>
        /// <param name="numbersArray">is a list of numbers received from the user</param>
        /// <returns>Highest number in array</returns>
        public static int Challenge5(int[] numbersArray)
        {
            int largeNumber = numbersArray[0];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > largeNumber)
                {
                    largeNumber = numbersArray[i];
                }
            }
            return largeNumber;

        }
        /// <summary>
        /// Creates a file if it doesn't exist and then adds/appends the word chosen by the user to the file
        /// </summary>
        static void Challenge6()
        {
            Console.WriteLine("What word would you like to save?");
            string[] word = new string[1];
            string words = Console.ReadLine();
            word[0] = words;
            string path = "../../Test.txt";
            File.AppendAllLines(path, word);
        }
        /// <summary>
        /// list all words in the file
        /// </summary>
        static void Challenge7()
        {
            string path = "../../Test.txt";
            string[] allLines = File.ReadAllLines(path);
            Console.WriteLine(String.Join('\n', allLines));
        }
        static void Challenge8()
        {
            string path = "../../Test.txt";
            string newPath = "../../temp.txt";

            Console.WriteLine("Word to be removed from file?");
            string deleteWord = Console.ReadLine();
            string[] readText = File.ReadAllLines(path);
            string[] writeText = new string[readText.Length - 1];
            int counter = 0;
            for (int i = 0; i < readText.Length; i++)
            {
                if (readText[i] != deleteWord)
                {
                    writeText[counter] = readText[i];
                    counter++;
                }
            }
            File.WriteAllLines(newPath, writeText);
            File.Delete(path);
            File.Move(newPath, path);
        }
        /// <summary>
        /// receives a sentance from the user and then returns a sentance with the number of characters in each word
        /// </summary>
        /// <param name="sentence">A string of a sentence given from the user</param>
        /// <returns>Reurns the new array with each word and length of the words</returns>
        public static string[] Challenge9(string sentence)
        {

            string[] sentenceArray = sentence.Split(" ");
            string[] count = new string[sentenceArray.Length];
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (sentenceArray.Length - 1 == i)
                {
                    count[i] += $" {sentenceArray[i]}: {sentenceArray[i].Length}";

                }
                else
                {
                    count[i] += $" {sentenceArray[i]}: {sentenceArray[i].Length},";

                }
            }
            return count;
        }
    }
}
