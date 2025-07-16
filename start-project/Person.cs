using System;

namespace start_project
{
    class Person
    {
        private string name;
        private int age;
        private double weight;
        private char gender;
        private bool isAlive;

        public Person()
        {
        
        }

        public Person(string name, int age, double weight, char gender, bool isAlive)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.gender = gender;
            this.isAlive = isAlive;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Is alive: " + isAlive);
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        public void setIsAlive(bool isAlive)
        {
            this.isAlive = isAlive;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public double getWeight()
        {
            return weight;
        }

        public char getGender()
        {
            return gender;
        }

        public bool getIsAlive()
        {
            return isAlive;
        }


    }
}