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
            //LinkedList linkedList = new LinkedList();

            //linkedList.AddToBegin(15);
            //linkedList.AddToBegin(11);
            //linkedList.AddToBegin(17);
            //linkedList.AddToBegin(11);
            //linkedList.Print();
            int k = 4;
            List<int> l = new List<int> { 1, 4, 6, 7, 4 };

            LinkedList<int> arr = new LinkedList<int>(l);

            var temp = arr.First;
            
            while(temp != null)
            {
                var nextNode = temp.Next;
                if(temp.Value == k)
                { 
                    arr.Remove(temp);
                    Console.WriteLine(temp.Value);

                }

                temp = nextNode;
            }
            foreach(var item in arr)
            {
                Console.Write($" {item}");
            }

            Console.ReadKey();
        }
    }
}
