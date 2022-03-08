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

            Employee winicius = new Employee("46743576813");
            Employee Fernando = new Director("485987541121");
            winicius.Name = "Winicius";
            winicius.Salary = 1000;

            Fernando.Name = "Fernando";

            Fernando.Salary = 5333;
            manager.Register(winicius);
            manager.Register(Fernando);
            Console.WriteLine(manager.getTotalBonus());
            Console.WriteLine(Employee.TotalEmplyee);


            Console.ReadLine();
        }
    }
}