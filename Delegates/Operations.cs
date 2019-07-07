using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Delegates
{
    public static class Operations
    {
        public delegate bool Operation(float a);

        public static float Sum(float[] arr, Operation op)
        {
            float sum = arr.Where(n => op(n)).Sum();
            return sum;
        }

        public static float Max(float[] arr, Operation op)
        {
            float max = arr.Where(n => op(n)).Max();
            return max;
        }

        public static float Avg(float[] arr, Operation op)
        {
            float avg = arr.Where(n => op(n)).Average();
            return avg;
        }
    }
}
