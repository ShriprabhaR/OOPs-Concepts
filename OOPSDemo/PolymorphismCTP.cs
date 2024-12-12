using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class PolymorphismCTP
    {
        static void Main(string[] args)
        {
            PolymorphismCTP poly = new PolymorphismCTP();
            Console.WriteLine("Sum of 2 numbers is: "+ poly.Add(10, 20));

            Console.WriteLine("Sum of 3 numbers is: "+ poly.Add(20, 30, 10));

            Console.WriteLine("Sum of 2 numbers is: "+ poly.Add(10.5, 20.9));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        //Overloaded method
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //Overloaded
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
