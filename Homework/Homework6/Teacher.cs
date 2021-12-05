using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Teacher : Person, ITeacher
    {
        private string Subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
