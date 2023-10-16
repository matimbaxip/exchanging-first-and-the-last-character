using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchanging_first_and_the_last_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string result = ExchangeFirstAndLastCharacters(input);

            Console.WriteLine("Result: " + result);

        }
        static string ExchangeFirstAndLastCharacters(string input)
        {
            if (input.Length <= 1)
                return input;

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];

            return lastChar + input.Substring(1, input.Length - 2) + firstChar;
        }

    }
}
