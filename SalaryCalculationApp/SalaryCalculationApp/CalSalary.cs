using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationApp
{
    class CalSalary
    {
        public string name;
        public double basic;
        public double medical;
        public double house;

        public double GetTotal()
        {

            double total = (GetHouse() + GetMedical() + basic); 
            return total;
        }

        public double GetHouse()
        {
            return (basic*house/100);
        }

        public double GetMedical()
        {
           return (basic * medical / 100);
        }



    }

}
