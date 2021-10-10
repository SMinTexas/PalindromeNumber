using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check to be a Palindrome: ");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
