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

        public void AddToEnd(int data)
        {
            if(Head == null)
            {
                Head = new Node(data);
            }else
            {
                Head.AddToEnd(data);
            }
        }
        public void AddToBegin(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = Head;
                Head = temp;
            }
        }

        public void Print()
        {
            if(Head != null)
            {
                Head.Print();
            }

        }
    }
}
