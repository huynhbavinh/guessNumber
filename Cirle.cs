using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercises
{
    class Cirle
    {
        private double radius;
        private string _color;

        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        public Cirle()
        {
            radius = 1.0;
            _color = "Red";
        }
        public Cirle(int number,string c0lor)
        {
            radius = (double)number;
            _color = c0lor;
        }
        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }
        public double getRadius()
        {
            return radius;
        }        
        public double Area()
        {
            return radius * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("The Circle has radius of {0} and color of {1}",radius,_color);
        }
    }
}
