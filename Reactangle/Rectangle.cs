using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }


        public double AreaCalculator()
        {
            return (side1 * side2);
        }

        public double PerimetrCalculator()
        {
            return (side1 + side2) * 2;
        }


        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimetr
        {
            get { return PerimetrCalculator(); }
        }
    }
}
