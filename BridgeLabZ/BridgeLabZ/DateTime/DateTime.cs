using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.DateTime
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Now       : " + DateTime.Now);
            Console.WriteLine("Today     : " + DateTime.Today);
            Console.WriteLine("UTC Now   : " + DateTime.UtcNow);
            Console.WriteLine("MinValue  : " + DateTime.MinValue);
            Console.WriteLine("MaxValue  : " + DateTime.MaxValue);
            Console.WriteLine();

            DateTime d1 = new DateTime(2025, 12, 9);
            DateTime d2 = new DateTime(2025, 12, 9, 11, 27, 0);

            Console.WriteLine("Custom Date      : " + d1);
            Console.WriteLine("Custom Date/Time : " + d2);
            Console.WriteLine();
            
            Console.WriteLine("Year       : " + d2.Year);
            Console.WriteLine("Month      : " + d2.Month);
            Console.WriteLine("Day        : " + d2.Day);
            Console.WriteLine("Hour       : " + d2.Hour);
            Console.WriteLine("Minute     : " + d2.Minute);
            Console.WriteLine("Second     : " + d2.Second);
            Console.WriteLine("DayOfWeek  : " + d2.DayOfWeek);
            Console.WriteLine("DayOfYear  : " + d2.DayOfYear);
            Console.WriteLine();

            Console.WriteLine("Add 5 Days  : " + d2.AddDays(5));
            Console.WriteLine("Add 2 Hours : " + d2.AddHours(2));
            Console.WriteLine("Yesterday   : " + DateTime.Now.AddDays(-1));
            Console.WriteLine();

            DateTime start = new DateTime(2025, 1, 1);
            DateTime end = new DateTime(2025, 12, 31);
            TimeSpan diff = end - start;

            Console.WriteLine("Days difference : " + diff.Days);
            Console.WriteLine();

            DateTime now = DateTime.Now;

            Console.WriteLine("Format: dd/MM/yyyy -> " + now.ToString("dd/MM/yyyy"));
            Console.WriteLine("Format: MM-dd-yyyy -> " + now.ToString("MM-dd-yyyy"));
            Console.WriteLine("Format: yyyy-MM-dd HH:mm:ss -> " + now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();

            DateTime parsed = DateTime.Parse("25/12/2025", new CultureInfo("en-IN"));
            Console.WriteLine("Parsed Date (IN format) : " + parsed);

            DateTime exact = DateTime.ParseExact("08-12-2025", "dd-MM-yyyy", null);
            Console.WriteLine("Exact Parsed Date        : " + exact);
            Console.WriteLine();

            DateTime? expiry = null;
            if (expiry == null)
                Console.WriteLine("Expiry Date: Not assigned yet");
        }
    }

}
