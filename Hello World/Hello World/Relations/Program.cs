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
            Employee winicius = new Employee(1);
            winicius.Name = "Winicius";
            winicius.Cpf = "46743576813";
            winicius.Salary = 1000;
            Console.WriteLine(winicius.GetBonus());

            Console.ReadLine();
        }
    }
}