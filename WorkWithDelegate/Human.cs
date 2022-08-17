using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithDelegate
{
    class Human
    {
        public delegate void Action();
        public void WakeUp()
        {
            Console.WriteLine("Wake Up!!!");
        }
        public void Smoking()
        {
            Console.WriteLine("Smoke!!!");
        }
        public void BreakFast()
        {
            Console.WriteLine("Eating !!!");
        }


    }
}
