using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Abstraction.AbstractClass
{
    public abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key turn.");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping using its brakes.");
        }
    }
    public class ElectricTrain : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Electric train is starting by powering up.");
        }

        public override void Stop()
        {
            Console.WriteLine("Electric train is stopping by cutting off the power.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Using Abstraction
            Vehicle myCar = new Car();
            Vehicle myTrain = new ElectricTrain();

            StartVehicle(myCar);
            StartVehicle(myTrain);

            Console.Read();
        }

        static void StartVehicle(Vehicle vehicle)
        {
            vehicle.Start();
        }
    }
}
