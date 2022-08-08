using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseGeneric
{
    class Program
    {
        public delegate int  Action();
        Action action = Sum1;


        static void Main(string[] args)
        {
            
        }
        public static  int Sum1()
        {
            Console.WriteLine("fd");
            return 0;
        }
        static T Sum<T>(T a)
        {
            return a;
        }
    }
}
