using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Student : Person, IStudent
    {
        public void GoToSchool()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age} years old.");
        }
    }
}
