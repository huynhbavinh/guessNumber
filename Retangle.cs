using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercises
{
    class Retangle
    {
        private float length;
        private float width;

        public Retangle()
        {
            this.length = 1.0f;
            this.width = 1.0f;
        }
        public Retangle(float length,float width)
        {
            this.length = length;
            this.width = width;
        }
        public float GetLength()
        {
            return this.length;
        }
        public void SetLength(float number)
        {
            this.length = number;
        }
        public float GetWidth()
        {
            return this.width;
        }
        public void SetWidth(float number)
        {
            this.width = number;
        }
        public double getArea()
        {
            return width * length;
        }
        public double getPerimeter()
        {
            return (width + length) * 2;
        }
        public override string ToString()
        {
            return String.Format("Retangle[width = {0},length = {1}]", width, length);
        }
    }
}
