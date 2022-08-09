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
            GivePrice givePrice = new GivePrice();
            givePrice.priceNow = ShowPrice;

            givePrice.Start();

            Console.ReadKey();
        }

      static public void ShowPrice(int price)
        {
            Console.WriteLine($"Price : {price}$");
        }
    }
}
