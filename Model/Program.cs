using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddToBegin(15);
            linkedList.AddToBegin(11);
            linkedList.Print();


            Console.ReadKey();
        }
    }
}
