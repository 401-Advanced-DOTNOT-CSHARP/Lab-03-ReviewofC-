using System;

namespace Lab_03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
            //Challenge1("1 2 3");
            //Challenge2Console();
               Challenge3();

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
            Console.WriteLine("Please input a number betwwen 1 and 10");
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
            for (int i = 1; i <= result; i++)
            {
                Console.WriteLine($"Please enter a number {i}/{result}");
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

    }
}
