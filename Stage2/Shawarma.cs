using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    class Shawarma : Food, DiscriptionFood
    {
        private double price;
        private bool diet;
        public void Size()
        {
            Console.WriteLine("We have : Small(0)|| Medium(1) || Big(2). What would you like?");

            string choose = Console.ReadLine();
            if(choose == "0")
            {
                price += 1800;
                Console.WriteLine("Price: "+ price);
            }else if(choose == "1")
            {

                price += 2200;
                Console.WriteLine("Price: " + price);
            }
            
        }
        public bool IsDiet()
        {
            Console.WriteLine("What do you prefer: Diet(Y) or Standar(N) ?");
            string choise = Console.ReadLine();

            if (choise == "Y")
            {
                price += 400;
                Console.WriteLine("Your Burger: isDiet and Price: "+price);
                diet = true;
                return true;
            }
            Console.WriteLine("Yor Burger: Standart");
            return false;
        }
        public void Price()
        {
            Console.WriteLine("Ultimate Price"+ price);
        }
        public void Caloria()
        {
            if(diet)
            {
                Console.WriteLine("Coloria: 189" );
            }else
            {
                Console.WriteLine("Coloria: 400");
            }
        }
       
    }
}
