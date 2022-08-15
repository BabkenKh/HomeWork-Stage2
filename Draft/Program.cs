using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    enum DayWeek : byte
    {
        Monday = 1,
        Tuesday ,
        Wednesday ,
        Thusday,
        Friday,
        Satruday,
        Sunday,
    }
    
    class Program
    {
        
        
        static public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
            

        }
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"X: {x} Y:{y}");
            //Swap(ref x, ref y);
            //Console.WriteLine($"X: {x} Y:{y}");
            DayWeek dayWeek = (DayWeek)1;
            Console.WriteLine(dayWeek);

            Console.WriteLine((byte)DayWeek.Monday);

            Console.ReadKey();
        }
    }
}
