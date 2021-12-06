using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----WHILE----");

            double investedAmount = 1000;
            int monthCounter = 1;

            while (monthCounter <= 12)
            {
                investedAmount = investedAmount + investedAmount * 0.0036;
                Console.WriteLine("After " + monthCounter + " month, you will have: " + "R$"+investedAmount);

                monthCounter = monthCounter + 1;

            }

            Console.WriteLine("----FOR----");


            for (int i = 1; i <= 12; i++)
            {
                investedAmount *= 1.0036;
                Console.WriteLine(
                    "After " + i +
                    " month, you will have: " + "R$" + investedAmount);
            }
        }
    }
}