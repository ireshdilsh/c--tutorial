using System;

namespace start_project
{

    // Inhericatnce java use extends keyword.but C# use : 
    class Student : Person
    {

    }

    class Inhericatnce
    {
        static void Main(string[] args)
        {
            Person person = new Student();
            person.setAge(45);
            person.PrintInfo();
        }
    }
}