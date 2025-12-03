using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Inheritance.MultilevelInheritance
{
    public class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    public class Car : Vehicle
    {
        public void PlayMusic()
        {
            Console.WriteLine("Car is playing music.");
        }
    }

    public class Bike : Vehicle
    {
        public void KickStart()
        {
            Console.WriteLine("Bike is kick-started.");
        }
    }

    public class Truck : Vehicle
    {
        public void LoadCargo()
        {
            Console.WriteLine("Truck is loading cargo.");
        }
    }

    public class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Start();
            car.PlayMusic();

            Bike bike = new Bike();
            bike.Start();
            bike.KickStart();

            Truck truck = new Truck();
            truck.Start();
            truck.LoadCargo();
        }
    }
}