using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Variables");

            Console.WriteLine("*-----INT-----*");

            int number;
            number = 32;

            number = 10;
            Console.WriteLine(number);

            number = 10 + 5;
            Console.WriteLine(number);

            number = 10 + 5 * 2;
            Console.WriteLine("Your number is: " + number);


            Console.WriteLine("*-----Double-----*");

            double wage;
            wage = 1220.70;

            Console.WriteLine(wage);


            Console.WriteLine("*-----Conversions-----*");

            float floatingPoint = 3.14f;

            double wage2 = 1270.50;
            int value = (int)wage2;
            Console.WriteLine(value);

            double value1 = 0.2;
            double value2 = 0.1;
            double total = value1 + value2;

            Console.WriteLine(total);


            Console.WriteLine("*-----Char and String-----*");

            char letter = 'a';
            Console.WriteLine(letter);

            //char value3 = 65;                    // error!
            //Console.WriteLine(value3);

            char value3 = (char) 65;
            value3 = (char)(value3 + 1);         // right!
            Console.WriteLine(value3);

            string word = "alura cursos online de tecnologia";
            Console.WriteLine(word);

            word = word + 2020;
            Console.WriteLine(word);
        }
    }
}