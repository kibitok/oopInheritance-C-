using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    class CommissionEmployee: Object
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;


        //five parameter constructor
        public CommissionEmployee (string first, string last, string social, decimal gross,decimal rate)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = social;
            grossSales = gross;
            commissionRate = rate;


        }

        //read only property that get commission employee first name.
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        //read only property that get commission employee last name.
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
         //read only property that get commission employee social security number.
        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }
        //read only property that get and set commission employee GrossSales.
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                {
                    grossSales = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales>=0");
                }
            }
        }
        //read only property that get and set commission employee commission rate.
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if(value > 0 && value < 1)
                {
                    commissionRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "commissionRate>0 and <1");
                }
            }
        }

        // calculate commission employee rate
        public virtual decimal Earnings()
        {
            return commissionRate * grossSales;
        }

        //return String representation of commission employee object
        public override string ToString()
        {
            return string.Format(
                "{0}:{1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",  
                "commission employee", FirstName, LastName, 
                "Social security number", SocialSecurityNumber,
                "Gross sales", GrossSales, "commission rate", CommissionRate
                );
        }
    }
}
