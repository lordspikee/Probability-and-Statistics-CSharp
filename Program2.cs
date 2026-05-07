using System;

class Program
{
    static void Main()
    {
        int[] data = { 115, 182, 191, 31, 196, 1099, 5, 172, 10, 179,
                       83, 21, 20, 21, 186, 177, 195, 193, 188, 199,
                       62, 109, 105, 183, 110 };

        int n = data.Length;

        Array.Sort(data);

        double Q1 = data[n / 4];
        double Q3 = data[(3 * n) / 4];

        double IQR = Q3 - Q1;

        double lowerLimit = Q1 - (1.5 * IQR);
        double upperLimit = Q3 + (1.5 * IQR);

        Console.WriteLine("Lower Limit = " + lowerLimit);
        Console.WriteLine("Upper Limit = " + upperLimit);

        Console.WriteLine("\nOutlier Results:");

        for (int i = 0; i < n; i++)
        {
            if (data[i] < lowerLimit || data[i] > upperLimit)
            {
                Console.WriteLine(data[i] + " is an outlier");
            }
            else
            {
                Console.WriteLine(data[i] + " is not an outlier");
            }
        }
    }
}
