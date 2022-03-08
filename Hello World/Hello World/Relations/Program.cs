using Relations;
using Relations.Employees;
using Relations.Systems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {


            //ReturnBonus();
            userSystem();

            Console.ReadLine();
        }

        public static void userSystem()
        {
            InternalSystem internalSystem = new InternalSystem();
            Director Mariana = new Director(23300, "883.009.233-34");
            Mariana.Name = "Mariana";
            Mariana.Password = "1123";

            internalSystem.login(Mariana, "123");
            internalSystem.login(Mariana, "1123");
        }

        public static void ReturnBonus()
        {
            BonusManager bonusManager = new BonusManager();
            Employee pedro = new Designer(2300, "883.009.233-46");
            pedro.Name = "Pedro";

            Employee Mariana = new Director(23300, "883.009.233-34");
            Mariana.Name = "Mariana";

            Employee Antonio = new Assistant(2300, "883.329.212-76");
            Antonio.Name = "Antonio";

            Employee Beto = new AccountManager(4300, "883.436.233-43");
            Beto.Name = "Beto";

            bonusManager.Register(pedro);
            bonusManager.Register(Mariana);
            bonusManager.Register(Antonio);
            bonusManager.Register(Beto);

            Console.WriteLine("Total bonus in the month: R$ " + bonusManager.getTotalBonus());
        }
    }
}