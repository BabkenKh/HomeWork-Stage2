using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByPassTrees
{
    class Program
    {
        static void Main(string[] args)
        { 
            BInaryTree binaryTree = new BInaryTree();
            Random rnd = new Random();
            int i = 0;

            while(i < 10)
            {
                binaryTree.Insert(rnd.Next(100));
                ++i;
            }

            Console.Write("Postorder: ");
            binaryTree.Postorder(binaryTree.root);
            Console.WriteLine();
            Console.Write("Inorder: ");
            binaryTree.Inorder(binaryTree.root);
            Console.WriteLine();
            Console.Write("Preorder: ");
            binaryTree.Preorder(binaryTree.root);

            Console.ReadKey();
        }
    }
}
