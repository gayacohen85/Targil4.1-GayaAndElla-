using System;
using System.Collections.Generic;
using System.Text;

namespace Targil4._1_GayaAndsElla_
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age;
        }
    }
}
