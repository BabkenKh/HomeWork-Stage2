using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    class Program
    {
     

        static void Main(string[] args)
        {
            Console.WriteLine("What do you want Shawarma(S) or Burger(B) ? ");
            
                string choose = Console.ReadLine();
                if (choose == "S")
                {
                    Shawarma shawarma = new Shawarma();
                    shawarma.Size();
                    shawarma.IsDiet();
                    shawarma.Price();
                    shawarma.Caloria();

                }
                else if (choose == "B")
                {
                   
                    
                }
                
            
            Console.ReadKey();
        }
    }
}
