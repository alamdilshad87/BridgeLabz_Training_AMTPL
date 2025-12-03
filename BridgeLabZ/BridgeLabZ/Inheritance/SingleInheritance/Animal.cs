using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Inheritance.SingleInheritance
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating.");
        }
    }

    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Dog dog = new Dog();

            dog.Eat();
            dog.Bark();
        }
    }
}

