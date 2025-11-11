using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Abstraction.AbstractClass
{
    public abstract class Animal
    {
        protected string name;

        // Constructor in abstract class
        public Animal(string animalName)
        {
            name = animalName;
            Console.WriteLine($"Animal constructor: {name}");
        }

        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name) // Calls base constructor
        {
            Console.WriteLine("Dog constructor");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} says: Woof!");
        }
    }
    public class Program1
    {
        public static void Main()
        {
            Dog dog = new Dog("Buddy");
            dog.MakeSound();
        }
    }
}
