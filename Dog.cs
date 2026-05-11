using System;
using System.Collections.Generic;
using System.Text;

namespace Targil4._1_GayaAndsElla_
{
     class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {

        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
}
