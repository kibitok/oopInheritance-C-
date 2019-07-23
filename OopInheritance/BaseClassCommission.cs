using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    class BaseClassCommission : CommissionEmployee
    {

        private decimal baseSalary;

        public BaseClassCommission (string first, string last, string social, 
            decimal gross, decimal rate, decimal salary): 
            base (first, last, social, gross, rate)
        {
            baseSalary = salary;
        }
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("the base salary", 
                        value, "base salary must be greater or equal to Zero");
                }
            }
         

        }
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }
        public override string ToString()
        {
            return string.Format("base-salaried {0}\n base salary: {1:C}", base.ToString(), BaseSalary);
        }

    }
}

