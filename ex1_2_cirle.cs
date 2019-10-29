using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercises
{
    class ex1_2_Circle
    {
        private double radius;

        public ex1_2_Circle ()
        {
            radius = 1;
        }
        public ex1_2_Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double number)
        {
            this.radius = number;
        }
        public double Area()
        {
            return radius*2 * Math.PI;
        }
        public double getCircumFerence()
        {
            return radius * radius * Math.PI; 
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0}]",radius);
        }
    }
}
