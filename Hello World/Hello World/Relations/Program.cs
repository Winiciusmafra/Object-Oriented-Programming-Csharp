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
            Employee Fernando = new Director();
            winicius.Name = "Winicius";
            winicius.Cpf = "46743576813";
            winicius.Salary = 1000;

            Fernando.Name = "Fernando";
            Fernando.Cpf = "485987541121";
            Fernando.Salary = 5333;
            manager.Register(winicius);
            manager.Register(Fernando);
            Console.WriteLine(manager.getTotalBonus());
            

            Console.ReadLine();
        }
    }
}