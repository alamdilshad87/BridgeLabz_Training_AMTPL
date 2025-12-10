using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Closures
{
    internal class AsyncClosure
    {
        public static async Task Main()
        {
            int x = 10;

            await Task.Run(async () =>
            {
                await Task.Delay(500);
                Console.WriteLine(x + " ");
            });
        }
    }
}
