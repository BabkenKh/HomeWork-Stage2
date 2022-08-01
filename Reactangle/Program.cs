using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactangle
{
    class Program
    {
        static int  Dupl(int[] arr, int n)
        {
            if (n == 0 || n == 1)
            { 
                return n; 
            }
                

            int j = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    arr[j++] = arr[i];
                }
                    
            }

            arr[j++] = arr[n - 1];

            return j;
        }
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle(12.3, 43);

            //double perimetr = rectangle.PerimetrCalculator();
            //double area = rectangle.AreaCalculator();

            //Console.WriteLine("Perimetr Rectangle: " + perimetr + "|| Area Rectangle: " + area);

            //Console.ReadKey();

            int[] arr = { 1, 1, 2, 3, 3, 5 };
            int n = arr.Length;

            n = Dupl(arr,n);




            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
