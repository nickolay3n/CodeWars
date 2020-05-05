using System;


//https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp
/*
Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.
Example: The binary representation of 1234 is 10011010010, so the function should return 5
     */
namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1234;
            Console.WriteLine(Kata.CountBits(i));
        }
    }
    public class Kata
    {
        public static int CountBits(int n)
        {
            int i = 0;
            while (n != 0)
                { 
                    i = (n % 2 == 0)? i : i+1; n=n >> 1; 
            }
            return i;
        }
    }
}
