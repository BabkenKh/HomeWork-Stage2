using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Animals
    {
        public override void Move()
        {
            Console.WriteLine("Foot Foot ...");
        }

        public override void Voice()
        {
            Console.WriteLine("Hav Hav ");
        }
        public override void Demestic()
        {
            Console.WriteLine("Yes");
        }
        public override void FootCount()
        {
            Console.WriteLine("4");
        }
        public override void Price()
        {
            Console.WriteLine("1000$");
        }
    }
}
