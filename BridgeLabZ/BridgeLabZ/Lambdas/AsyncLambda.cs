using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Lambdas
{
    internal class AsyncLambda
    {
        public static async Task Main()
        {
            Func<int, int, Task<int>> addAsync = async (a, b) =>
            {
                await Task.Delay(500);
                return a + b;
            };

            int result = await addAsync(5, 7);
            Console.WriteLine("Sum = " + result);
        }
    }
}