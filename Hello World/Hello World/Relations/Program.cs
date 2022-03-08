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

            Employee winicius = new Employee(1000,"46743576813");
            Employee Fernando = new Director(5333,"485987541121");
            winicius.Name = "Winicius";
            Console.WriteLine("Winicius Salary: "+ winicius.Salary);
            Fernando.Name = "Fernando";
           
            Console.WriteLine("Fernando Salary: " + Fernando.Salary);
            manager.Register(winicius);
            manager.Register(Fernando);
            winicius.IncreaseSalary();
            Fernando.IncreaseSalary();
            Console.WriteLine("New salary Winicius " + winicius.Salary);
            Console.WriteLine("New salary Fernando " + Fernando.Salary);



            Console.ReadLine();
        }
    }
}