using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithDelegate
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Human human = new Human();
            Action action = new Action(human.WakeUp);

            action += human.BreakFast;
            action += human.Smoking;

            action.Invoke();

            Console.ReadKey();
        }

      static public void ShowPrice(int price)
        {
            Console.WriteLine($"Price : {price}$");
        }
    }
}
