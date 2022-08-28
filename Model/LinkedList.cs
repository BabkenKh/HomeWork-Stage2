using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class LinkedList
    {
        private Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void InsertBegin(int data)
        {
            Node newNode = new Node();
            newNode.value = data;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;         
                Head = newNode;
                Head.next = current;
                Head.next.previous = Head;
                Head.previous = null;

            }
        }
        public void Print()
        {
            Console.WriteLine(" Value"+Head.next.previous.value);
        }
    }
}
