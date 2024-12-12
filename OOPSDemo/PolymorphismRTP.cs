using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    public class PolymorphismRTP
    {
        public virtual void Area()
        {
            Console.WriteLine("Area of shape ");
        }

        static void Main(string[] args)
        {
           PolymorphismRTP rtp;

           rtp = new Circle();
           rtp.Area();

           rtp = new Square();
           rtp.Area();

            Console.ReadLine();

        }


    }

    public class Circle : PolymorphismRTP
    {
        
        public override void Area() 
        {
            double pi = 3.142;
            int radius = 20;
            double area = pi * radius * radius;
            Console.WriteLine("area of circle: "+area);

        }

    }

    public class Square : PolymorphismRTP
    {
        public override void Area()
        {
            int length = 10;
            int breadth = 15;
            int area = length * breadth;
            Console.WriteLine("area of Square: " + area);
        }
    }
    
}
