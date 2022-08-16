using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Node
    {
        public int value { get; set; }

        public Node next { get; set; }

        public Node(int value)
        {
            this.value = value;
            next = null;
        }

        public void AddToEnd(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }else
            {
                next.AddToEnd(data);
            }
        }
        public void Print()
        {
            Console.Write($"|{value}| -> ");
            if(next != null)
            {
                next.Print();
            }
        }
    }
}
