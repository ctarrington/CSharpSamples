using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSample
{
    class Fibonacci
    {
        public static IEnumerable<long> GetFirst(int count)
        {
            yield return 0;
            yield return 1;

            int ctr = 0;
            long first = 0;
            long second = 1;

            while (ctr++ < count-2)
            {               
                long value = first + second;
                Console.WriteLine("calculated: " + value);
                first = second;
                second = value;
                yield return value;
            }

        }

    }
}
