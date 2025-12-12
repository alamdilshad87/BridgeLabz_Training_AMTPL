using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Events
{
    internal class SimpleEvent
    {
        public delegate void Notify();

        class Process
        {
            public event Notify ProcessCompleted;

            public void Start()
            {
                Console.WriteLine("Process Started!");
                ProcessCompleted?.Invoke();
            }
        }

        class Subscriber
        {
            public void OnProcessCompleted()
            {
                Console.WriteLine("Process Completed Event Received");
            }
        }

        class Program
        {
            public static void Main()
            {
                Process p = new Process();
                Subscriber s = new Subscriber();

                p.ProcessCompleted += s.OnProcessCompleted;

                p.Start();
            }
        }
    }
}