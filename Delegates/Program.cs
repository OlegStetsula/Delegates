using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations.Operation op = x => x > 0;
            float[] arr = { -4, 0, 4, 3, -9, 8, 2};
            float sum = Operations.Sum(arr, op);

            Console.WriteLine("sum of array is {0}", sum);

            float max = Operations.Max(arr, op);
            Console.WriteLine("max of array is {0}", max);

            float avg = Operations.Avg(arr, op);
            Console.WriteLine("avg of array is {0}", avg);

            Console.ReadLine();

        }
    }
}
