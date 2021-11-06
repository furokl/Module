using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule
{
    public static class ArrayManager
    {
        public static int FindMax(int[] a)
        {
            if (a == null)
                throw new NullReferenceException("Массив не задан");

            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            return max;
        }

        public static double GetAverage(int[] a)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return (double)sum / a.Length;
        }
    }
}
