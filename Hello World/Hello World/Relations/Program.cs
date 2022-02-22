using Relations;
using Relations.Employees;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BonusManager manager = new BonusManager();

            Employee winicius = new Employee();
            winicius.Name = "Winicius";
            winicius.Cpf = "46743576813";
            winicius.Salary = 1000;
            manager.Register(winicius);
            Console.WriteLine(winicius.GetBonus());
            

            Console.ReadLine();
        }
    }
}