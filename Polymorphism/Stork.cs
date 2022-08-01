using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Stork : Animals
    {
        public override void Move()
        {
            Console.WriteLine("Foot Foot ...");
        }

        public override void Voice()
        {
            Console.WriteLine(" iuuu ");
        }
        public override void Demestic()
        {
            Console.WriteLine("No");
        }
        public override void FootCount()
        {
            Console.WriteLine("2");
        }
    }
}
