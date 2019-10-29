using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirle c1 = new Cirle();
            Console.WriteLine("{0} is radius, {1} is Area of the circle, {2} is color of Circle",
                c1.getRadius(),c1.Area(),c1.Color = "pink");
            Cirle c2 = new Cirle(7,"Pink");
            c2.setRadius(5);
            Console.WriteLine("{0} is radius, {1} is Area of the circle,  {2} is color of Circle",
                c2.getRadius(), c2.Area(),c2.Color = "ORgane");
            Console.WriteLine(c2.ToString());
        }
    }
}
