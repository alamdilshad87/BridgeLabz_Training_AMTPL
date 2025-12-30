using System;
class TemperatureAnalyzer
{
    public static void AnalyzeTemperatures(double[,] temperatures, out int hottestDay, out int coldestDay, out double[] dailyAverages)
    {
        int days = 7;
        int hours = 24;
        dailyAverages = new double[days];
        for (int i = 0; i < days; i++)
        {
            double sum = 0;
            for (int j = 0; j < hours; j++)
            {
                sum += temperatures[i, j];
            }
            dailyAverages[i] = sum / hours;
        }

        hottestDay = 0;
        coldestDay = 0;

        for (int i = 1; i < days; i++)
        {
            if (dailyAverages[i] > dailyAverages[hottestDay])
                hottestDay = i;

            if (dailyAverages[i] < dailyAverages[coldestDay])
                coldestDay = i;
        }
    }
    public static void Main()
    {
        double[,] temperatures = new double[7, 24]
        {
            {30,31,29,28,12,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27},
            {30,31,29,28,38,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27},
            {30,31,29,28,27,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27},
            {30,31,29,28,27,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27},
            {30,31,29,28,27,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27},
            {30,31,29,28,27,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27},
            {39,31,29,28,27,26,25,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28,27}
        };

        int hottestDay, coldestDay;
        double[] dailyAverages;

        AnalyzeTemperatures(temperatures, out hottestDay, out coldestDay, out dailyAverages);

        Console.WriteLine("Hottest Day Index: " + hottestDay);
        Console.WriteLine("Coldest Day Index: " + coldestDay);

        Console.WriteLine("Daily Average Temperatures:");
        for (int i = 0; i < dailyAverages.Length; i++)
        {
            Console.WriteLine($"Day {i}: {dailyAverages[i]:F2} °C");
        }
    }
}
