using System;
using System.Collections.Generic;
using System.Text;

namespace Targil4._1_GayaAndsElla_
{
    sealed class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }


        public void Purr()
        {
            Console.WriteLine("Purr");
        }
    }
}
