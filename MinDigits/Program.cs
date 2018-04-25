using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDigits
{
    class Kata
    {
        public static long MinValue(int[] a)
        {
            var useInts = a.Distinct().ToArray();
            var result = "";
            Array.Sort(useInts);
            foreach (int item in useInts)
            {
                Console.WriteLine(item);
                result += item;
            }
            var end = Convert.ToInt32(result);
            return end;
        }
    }
}