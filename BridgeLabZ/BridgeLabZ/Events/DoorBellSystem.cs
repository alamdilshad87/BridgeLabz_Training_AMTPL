using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Events
{
    internal class DoorBellSystem
    {
        public delegate void DoorBellHandler();
        class Door
        {
            public event DoorBellHandler BellRang;

            public void RingBell()
            {
                Console.WriteLine("Bell Pressed");
                BellRang?.Invoke();
            }
        }

        class Person
        {
            public string _name;
            public Person(string name)
            {
                _name = name;
            }

            public void Respond()
            {
                Console.WriteLine($"{_name} says : Coming to open the door");
            }
        }

        class Program
        {
            public static void Main()
            {
                Person p1 = new Person("Dilshad");
                Person p2 = new Person("Pranav");
                Person p3 = new Person("Gaurav");

                Door door = new Door();
                door.BellRang += p1.Respond;
                door.BellRang += p2.Respond;
                door.BellRang += p3.Respond;
                door.RingBell();
                door.BellRang -= p2.Respond;
                door.RingBell();
            }
        }
    }
}
