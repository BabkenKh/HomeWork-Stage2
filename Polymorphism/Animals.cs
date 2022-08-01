using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Animals
    {
        public abstract void Move();
        public abstract void Voice();
        public abstract void FootCount();
        public abstract void Demestic();
        public virtual void Price() { }

    }
}
