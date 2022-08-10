using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculate salaryCalculate = new SalaryCalculate();

            salaryCalculate.salary = new Salary(PureSalary);
            salaryCalculate.salary += GrossSalary;
            //salaryCalculate.Start();

            var results = salaryCalculate.salary.GetInvocationList().Select(x => (double)x.DynamicInvoke(100000.0));
            foreach (var result in results)
            Console.WriteLine(result);

            Console.WriteLine();

            Console.ReadKey();
        }

        public static double PureSalary(double price)
        {
            double pureSalary = price - (price * 0.3);

            return pureSalary;
        }

        public static double GrossSalary(double price)
        {
            
            return price;
        }

        public static double Print(double price)
        {
        
            return price;
        }
    }
}


