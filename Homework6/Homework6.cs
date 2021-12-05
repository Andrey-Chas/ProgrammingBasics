using System;

namespace Homework6
{
    class Homework6
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Jhon",
                Surname = "Jonson"
            };

            student.SetAge(23);
            student.ShowAge();
            student.GoToSchool();

            Teacher teacher = new Teacher
            {
                Name = "Jack",
                Surname = "Brown"
            };

            teacher.Explain();

        }
    }
}
