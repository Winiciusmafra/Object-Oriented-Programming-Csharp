using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CurrentAcconut currentWinicius = new CurrentAcconut();
            currentWinicius.holder = "Winicius";
            currentWinicius.agency = 0001;
            currentWinicius.currentAccount = 29384;
            currentWinicius.balance = 2000;
            Console.WriteLine("Name: " + currentWinicius.holder);
            //Console.WriteLine("Agency: " + currentWinicius.agency);
            //Console.WriteLine("Account: " + currentWinicius.currentAccount);
            Console.WriteLine("Balance: " + currentWinicius.balance);
            /*----------------------------------------------------*/
            currentWinicius.Withdraw(50);
            Console.WriteLine("Withdraw made of: " + 50);
            Console.WriteLine("New Balance: " + currentWinicius.balance);

            currentWinicius.Deposit(20);
            Console.WriteLine("Deposit made of: " + 20);
            Console.WriteLine("New Balance: " + currentWinicius.balance);

            Console.ReadLine();

        }
    }
}