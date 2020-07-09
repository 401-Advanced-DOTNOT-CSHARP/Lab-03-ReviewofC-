using System;
using System.IO;

namespace Lab_03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
            Challenge1("1 2 3");
            Challenge2Console();
               Challenge3();
                Challenge4(new int[] {1, 1, 2, 3, 4, 2, 3, 2});
                Challenge5(new int[] {10, 15, 5, -9, 30});
                */
                Challenge6();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }

        public static int Challenge1(string numbers)
        {
            string[] numbersArray = numbers.Split(' ');

            if(numbersArray.Length < 3)
            {
                return 0;
            }

            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                if(int.TryParse(numbersArray[i], out int result)){

                product *= result;
                }
                else
                {
                    product *= 1;
                }
            }
                return product;
        }
        public static void Challenge2Console()
        {
            Console.WriteLine("Please input a number betwwen 2 and 10");
            string userNumbers = Console.ReadLine();
            if(!int.TryParse(userNumbers, out int result))
            {
                throw new Exception("You did not enter a number, try again");

            }else if (result < 2 || result > 10)
            {
                throw new Exception("you either entered a number below 2 or higher than 10, try again");
            }
            else
            {
            int[] numbersArray = new int[result];
            for (int i = 0; i < result; i++)
            {
                Console.WriteLine($"Please enter a number {i+1}/{result}");
                string newNumber = Console.ReadLine();
                    if(int.TryParse(newNumber, out int results))
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
        public static decimal Challenge2(int[] numbers)
        {
            decimal total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total /= numbers.Length;
        }
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

                if(numbersArray[i] == numbersArray[j])
                {
                    count += 1;
                    numberCounted = numbersArray[i];
                }
                }
                if(leadCount < count)
                {
                    leadNumber = numberCounted;
                    leadCount = count;
                }
            }
            return leadNumber;
        }
        public static int Challenge5(int[] numbersArray)
        {
            int largeNumber = numbersArray[0];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if(numbersArray[i] > largeNumber)
                {
                    largeNumber = numbersArray[i];
                }
            }
            return largeNumber;

        }
        static void Challenge6()
        {
            Console.WriteLine("What word would you like to save?");
            string word = Console.ReadLine();
            string path = "../../Test.txt";
            File.WriteAllText(path, word);
        }

    }
}
