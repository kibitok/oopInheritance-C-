using System;

namespace OopInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
          
        }
        public void commissionEmployeeTest()
        {
            CommissionEmployee employee = new CommissionEmployee("Jones", "Sue", "22-222-222-222", 10000.0M, .06M);

            Console.WriteLine(
                "Employee information obtained by properties and methods \n");

            Console.WriteLine("First name is {0}", employee.FirstName);

            Console.WriteLine("Last name is {0}", employee.LastName);

            Console.WriteLine("Social Security number is {0}", employee.SocialSecurityNumber);

            Console.WriteLine("Gross sales are {0:C}", employee.GrossSales);

            Console.WriteLine("Commission rate is {0:F2}", employee.CommissionRate);

            Console.WriteLine("Earnings are {0:C}", employee.Earnings());

            employee.GrossSales = 5000.00M;
            employee.CommissionRate = .1M;

            Console.WriteLine("\n{0}:\n\n{1}",
                "Updated employee information obtained by ToString", employee);

            Console.WriteLine("earnings: {0:C}", employee.Earnings());


            Console.ReadKey();



        }
        public static void baseClassCommisionTest()
        {
            BaseClassCommission employee = new BaseClassCommission("Bett", "Sue", "3333-333-333", 10000.0M, .06M, 300.00M);

            Console.WriteLine(
                "Employee information obtained by properties and methods \n");

            Console.WriteLine("First name is {0}", employee.FirstName);

            Console.WriteLine("Last name is {0}", employee.LastName);

            Console.WriteLine("Social Security number is {0}", employee.SocialSecurityNumber);

            Console.WriteLine("Gross sales are {0:C}", employee.GrossSales);

            Console.WriteLine("Commission rate is {0:F2}", employee.CommissionRate);

            Console.WriteLine("Earnings are {0:C}", employee.Earnings());

            Console.WriteLine("Base Salary is {0:C}", employee.BaseSalary);

            employee.BaseSalary = 1000M;


            Console.WriteLine("\n{0}:\n\n{1}",
                "Updated employee information obtained by ToString", employee);

            Console.WriteLine("earnings: {0:C}", employee.Earnings());


            Console.ReadKey();

        }
        public static void baseDerivedInherit()
        {
            BaseClassCommission employee = new BaseClassCommission("Bett", "Sue", "444-444-444", 1000.0M, 0.4M, 600M);


            // Displaying Employee Data

            Console.WriteLine("First Name is {0}", employee.FirstName);
            Console.WriteLine("Last Name is {0}", employee.LastName);
            Console.WriteLine("Social Security Number is {0}", employee.SocialSecurityNumber);
            Console.WriteLine("Gross saless is {0:C}", employee.GrossSales);
            Console.WriteLine("Commission rate  is {0:F2}", employee.CommissionRate);
            Console.WriteLine("The earnings is {0:C}", employee.Earnings());
            Console.WriteLine("The base Salary is {0:C}", employee.BaseSalary);

            employee.BaseSalary = 3000.0M;

            Console.WriteLine("\n{0}:\n\n{1}", "updated employee information by Tostring()", employee);

            Console.WriteLine("Earnings:{0:C}", employee.Earnings());

            Console.ReadKey();
        }


    }



}
