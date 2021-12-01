using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----IF----");


            int age = 20;
            int amountPeople = 3;

            if (age >= 18)
            {
                Console.WriteLine("You are older than 18");
                Console.WriteLine("Wellcome");
            }
            else
            {
                if (amountPeople >= 2)
                {
                    Console.WriteLine("you are not 18 years old, but you can enter, you are accompanied");

                }
                else
                {
                    Console.WriteLine("sorry, but you can't join");
                }
            }

            Console.WriteLine("----IF bool----");

            int ageJoao = 18;
            bool alone = true;

            if (ageJoao >= 18 && alone == false)
            {
                Console.WriteLine("Can join");
            }
            else
            {
                Console.WriteLine("Can't join");
            }
        }
    }
}