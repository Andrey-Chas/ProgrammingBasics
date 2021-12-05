using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class StudentAndTeacherTest
    {
        static void Main()
        {
            Person person = new Person
            {
                Name = "Nordy",
                Surname = "Clow"
            };

            person.SayHello();

            Student student = new Student
            {
                Name = "Jhon",
                Surname = "Jonson"
            };

            student.SetAge(21);
            student.SayHello();
            student.ShowAge();
            student.GoToSchool();

            Teacher teacher = new Teacher
            {
                Name = "Jack",
                Surname = "Brown"
            };

            teacher.SetAge(30);
            teacher.SayHello();
            teacher.Explain();
        }
    }
}
