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

            linkedList.InsertBegin(15); 
            linkedList.InsertBegin(12);
            linkedList.Print();
            linkedList.InsertBegin(18);
            linkedList.Print();




            Console.ReadKey();
        }
    }
}
