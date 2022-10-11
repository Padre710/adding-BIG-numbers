using System;
using System.Numerics;

//We need to sum big numbers and we require your help.

//Write a function that returns the sum of two numbers.
//The input numbers are strings and the function must return a string.

//Example
//add("123", "321"); -> "444"
//add("11", "99");   -> "110"
//Notes
//The input numbers are big.
//The input is a string of only digits
//The numbers are positives

namespace adding_BIG_numbers
{
    public class Kata
    {
        public static string Add(string a, string b)
        {
            BigInteger big = BigInteger.Parse(a) + BigInteger.Parse(b);
            return  big.ToString();
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.Add("123456789", "987654322"));
            Console.WriteLine(Kata.Add("999999999", "1"));
        }
    }
}
