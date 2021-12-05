using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            Age = n;
        }
    }
}
