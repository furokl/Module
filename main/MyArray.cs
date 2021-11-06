using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule
{
    public class MyArray
    {
        private int[] _a;

        public MyArray(int[] a)
        {
            _a = a;
        }
        public int FindMax()
        {
            if (_a == null)
                throw new NullReferenceException("Массив не задан");

            int max = _a[0];
            for (int i = 0; i < _a.Length; i++)
            {
                if (_a[i] > max)
                    max = _a[i];
            }

            return max;
        }
    }
}
