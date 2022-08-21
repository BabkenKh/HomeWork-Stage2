using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByPassTrees
{
    class BInaryTree
    {
        public Node root { get; private set; }

        public BInaryTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node();
            newNode.value = data;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (data < current.value)
                    {
                        current = current.lef;
                        if (current == null)
                        {
                            parent.lef = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Search(int data)
        {
            Node current = root;

            while (current != null)

            {

                if (data == current.value)
                {
                    Console.WriteLine("Your element exist!!!");
                    return;
                }
                else if (data < current.value)
                {
                    current = current.lef;
                }
                else
                {
                    current = current.right;
                }
            }
            Console.WriteLine("Your element non exsist!!!");

        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.value + " ");
                Preorder(Root.lef);
                Preorder(Root.right);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.lef);
                Console.Write(Root.value + " ");
                Inorder(Root.right);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.lef);
                Console.Write(Root.value + " ");
                Postorder(Root.right);
            }
        }
    }
}
