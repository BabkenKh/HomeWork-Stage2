using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Thred
{
    class Program
    {
        static async Task foo()
        {
            await Task.Run(() =>
            {
                for(int i = 1; i <= 1000; i++)
                {
                    Console.WriteLine("11111");
                }
                   
            });
        }
        static async void foo3()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("TASK11111111");
            }
        }
        static async void foo4()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("TASK222");
            }
        }

        static async Task foo2()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 1000; i++)
                {
                    Console.WriteLine("2");
                }

            });
        }
        
        static void Main(string[] args)
        {

           Thread thread1 = new Thread(foo3);
           Thread thread2 = new Thread(foo4);
            thread1.Start();
            thread2.Start();


           
            Console.Read();

        }
    }
}
