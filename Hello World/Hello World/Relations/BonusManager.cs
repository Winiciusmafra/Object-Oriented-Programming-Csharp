using Relations.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class BonusManager
    {
        private double _totalBonus;
        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }
        public void Register(Director director)
        {
            _totalBonus += director.GetBonus();
        }


        public double getTotalBonus()
        {
            return _totalBonus;
        }
    }
}
