using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public delegate double Salary(double price);
    class SalaryCalculate
    {
        public Salary salary { get; set; }

        //double salary1 = 100000.0;
    //    public void Start()
    //    {
    //        salary(salary1);

    //    }
    }
}
