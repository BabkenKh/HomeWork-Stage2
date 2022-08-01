using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    class Burger : Food
    {

        private int myVar;

        public int MyProperty
        {
            get
            {
                return myVar;
            }
            set
            {
                myVar = value;
            }
        }


    }
}
