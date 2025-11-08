using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Constructor.TypesOfConstructor
{
    internal class PrivateConstructor
    {
        public static int objectCount;
        public string Name;
        // Private Constructor — prevents direct object creation
        private PrivateConstructor()
        {
            Name = "Singleton Example";
            objectCount++;
        }
        public static PrivateConstructor CreateObject()
        {
            return new PrivateConstructor();
        }
        public void Display()
        {
            Console.WriteLine($"Object {objectCount}: {Name}");
        }
        public static void Main(string[] args)
        {
            PrivateConstructor obj1 = PrivateConstructor.CreateObject();
            obj1.Display();
            PrivateConstructor obj2 = PrivateConstructor.CreateObject();
            obj2.Display();
        }
    }
}
