using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {// for loop for fizz buzz runs through 20 numbers
            for (var i = 0; i < 20; i++)
            {
                FizzBuzz(i); // calling fizzbuzz function
            }
            LetterCounter("i", "I love biscuits and gravy. It's the best breakfast ever");
            LetterCounter("n", "Never gonna give you up. Never gonna let you down.");
            LetterCounter("s", "sally sells seashells down the seashore. She's from Sussex.");
            Textstats("I'm doing it");


            Console.ReadKey();
        }

        static void FizzBuzz(int number)//fizzbuzz function
        {

            {
                if (number % 5 == 0 && number % 3 == 0)// check number in fizz buzz is divisable by or equal to 0 if so print "string"
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
        static void LetterCounter(string Letter, string inString)//LetterCounter function
        {
            int LetterLower = 0;
            int LetterUpper = 0;
            int TotalLetter = 0;
            var LetterUppers = Letter.ToUpper();
            var LetterLowers = Letter.ToLower();

            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == LetterUppers)
                {
                    LetterUpper++;
                    TotalLetter++;
                }
                else if (inString[i].ToString() == LetterLowers)
                {
                    LetterLower++;
                    TotalLetter++;
                }

                {

                }
            }
            Console.WriteLine("input: " + inString);
            Console.WriteLine("Number of uppercase letters found " + LetterUpper + ".");
            Console.WriteLine("Number of lowercase letters found " + LetterLower + ".");
            Console.WriteLine("Tottal number of letters found " + TotalLetter + ".");
        }
        static void Textstats(string input)
        {
           
            var numVowels = 0;
            var numConst = 0;
            var numSpecial = 0;
            var longWord = "doing";
            var shortWord = "it";
            

            string[] myArray = {"I'm", "doing","it"};
            foreach (string item in myArray)
            {
                Console.WriteLine(item);
            }
            for (var i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'o')
                {
                    numVowels += 1;
                }
                else if (c == '.' || c == ',' || c == '!' || c == '?' || c == ' ')
                {
                    numSpecial += 1;
                    
                }
                else
                {
                    numConst += 1;
                }
                Console.WriteLine("number of characters is " + input.Length);
                Console.WriteLine("number of words is " + longWord);
                Console.WriteLine("number of words is " + shortWord);
                Console.WriteLine("number of vowels is " + numVowels);
                Console.WriteLine("number of vowels is " + numConst);
                Console.WriteLine("number of vowels is " + numSpecial);
            }
        }


    }
}