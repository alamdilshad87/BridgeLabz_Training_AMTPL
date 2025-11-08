using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class FlipCoin
    {
        static void Main()
        {
            int flips;
            Console.WriteLine("Enter number of times to flip the coin: ");
            while (!int.TryParse(Console.ReadLine(), out flips) || flips <= 0)
            {
                Console.Write("Please enter a positive integer: ");
            }

            int heads = 0, tails = 0;
            Random random = new Random();

            for (int i = 0; i < flips; i++)
            {
                double result = random.NextDouble();
                if (result < 0.5)
                    tails++;
                else
                    heads++;
            }

            double headPercentage = (heads * 100.0) / flips;
            double tailPercentage = (tails * 100.0) / flips;

            Console.WriteLine("\nResults after " + flips + " flips:");
            Console.WriteLine("Heads: " + headPercentage + "%");
            Console.WriteLine("Tails: " + tailPercentage + "%");
        }
    }
}
