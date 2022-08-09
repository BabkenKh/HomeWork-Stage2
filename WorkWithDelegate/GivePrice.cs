using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkWithDelegate
{
    public delegate void PriceNow(int price);
    class GivePrice
    {
        public PriceNow priceNow { get; set; }

        public void Start()
        {

            while(true)
            {
                int GetPriceFromBank = new Random().Next(100);
                 
                priceNow(GetPriceFromBank);

                Thread.Sleep(2000);
            }
        }
    }
}
