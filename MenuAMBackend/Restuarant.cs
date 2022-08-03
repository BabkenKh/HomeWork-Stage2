using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAMBackend
{
    abstract class Restuarant
    {
        public abstract void CloseOpen();
        public abstract bool isDelivery();
        public abstract void Repay();



    }
}
