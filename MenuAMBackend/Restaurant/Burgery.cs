using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAMBackend
{
    class Burgery : Restuarant, IConditional
    {
        public string Adress { get; set; } = "3, 37 Amiryan St, Yerevan 0010 ";
        public string PhoneNumber { get; set; } = "043 997700";
        public override void CloseOpen()
        {
            Console.WriteLine("9:00am - 8:00pm");
        }
        public override bool isDelivery()

        {
            return false;
        }

        
        public override void Repay()
        {
            Console.WriteLine();
        }


    }
}
