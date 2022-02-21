using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CurrentAcconut currentWinicius = new CurrentAcconut();

            //currentWinicius.holder = "Winicius";
            //currentWinicius.agency = 0001;
            //currentWinicius.currentAccount = 29384;
            //currentWinicius.balance = 2000;
            //Console.WriteLine("Name: " + currentWinicius.holder);
            //Console.WriteLine("Agency: " + currentWinicius.agency);
            //Console.WriteLine("Account: " + currentWinicius.currentAccount);
            //Console.WriteLine("Balance: " + currentWinicius.balance);
            ///*----------------------------------------------------*/
            //currentWinicius.Withdraw(50);
            //Console.WriteLine("Withdraw made of: " + 50);
            //Console.WriteLine("New Balance: " + currentWinicius.balance);

            //currentWinicius.Deposit(20);
            //Console.WriteLine("Deposit made of: " + 20);
            //Console.WriteLine("New Balance: " + currentWinicius.balance);

            ///*-------------------Function Transfer---------------------------------*/
            //CurrentAcconut currentMariana = new CurrentAcconut();
            //currentMariana.holder = "Mariana";
            //currentMariana.agency = 0201;
            //currentMariana.currentAccount = 29324;
            //currentMariana.balance = 0;
            //Console.WriteLine("Previous value: Winicius - " + currentWinicius.balance);
            //Console.WriteLine("Previous value: Mariana - " + currentMariana.balance);
            //currentWinicius.Transfer(10, currentMariana);
            //Console.WriteLine("Winicius made a trasnfer of : " + 10 + " from Mariana");
            //Console.WriteLine("New value: Winicius - " + currentWinicius.balance);
            //Console.WriteLine("New value: Mariana - " + currentMariana.balance);

            /*1.4 - namespace*/
            Holder Winicius = new Holder();
            Winicius.name = "Winicius";
            Winicius.cpf = "35968475125";
            Winicius.profession = "Student";
            CurrentAcconut current = new CurrentAcconut();
            current.holder = Winicius;
            current.agency = 1548;
            current.currentAccount = 5484777;
            //current.balance = 1488;
            //Console.WriteLine(Winicius.name);
            //Console.WriteLine(current.holder.name);
            current.SetBalance(10);
            Console.WriteLine(current.GetBalance());


            Console.ReadLine();

        }
    }
}