using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class SingleLevelInheritance
    {

        class Person
        {
            int age = 22;
            String name = "Shri";

            public void Display()
            {
                Console.WriteLine("Name: " + name + " Age: " + age);
            }
        }

        class Employee : Person
        {
            static void Main(string[] args)
            {
                Employee e = new Employee();
                e.Display();
            }

        }
    }
}
