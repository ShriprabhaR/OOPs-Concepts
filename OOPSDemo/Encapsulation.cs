using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Encapsulation
    {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
                    
                
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}\nAge: {Age}");
            }

            static void Main(string[] args)
            {
                Encapsulation person = new Encapsulation();

                Console.Write("Enter your name: ");
                person.Name = Console.ReadLine();

                Console.Write("Enter your age: ");
                person.Age = int.Parse((Console.ReadLine()));
              

                person.DisplayInfo();
            }
        
    }
}

