using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAndPredicates();
            
            EnumerableFromLinq();
            CustomEnumerable();

        }

        // show that LINQ pulls from the Enumerable only as needed.
        private static void CustomEnumerable()
        {
            IEnumerable<long> fibonacci = Fibonacci.GetFirst(50);
            foreach (long n in fibonacci)
            {
                Console.WriteLine("fib: " + n);
            }


            IEnumerable<long> oddFibs = fibonacci.Where(n => (n % 2 != 0));
            foreach (long n in oddFibs)
            {
                Console.WriteLine("oddFib: " + n);
            }

            IEnumerable<long> evenFibs = fibonacci.Where(n => (n % 2 == 0));
            foreach (long n in evenFibs)
            {
                Console.WriteLine("evenFib: " + n);
            }


        }

        private static void EnumerableFromLinq()
        {
            List<int> numbers = new List<int>(new int[] { 1, 2, 5, 4, 1, 7, 8, 9, 1, 11, -1, -2, -1, 0 });

            // an inline predicate passed as a parameter
            IEnumerable<int> odds = numbers.Where(n => (n % 2 != 0));
            System.Console.WriteLine("EnumerableFromLinq: odds = " + string.Join(", ", odds));

            // define the predicate seperately
            Func<int, bool> isEven = n => (n % 2 == 0);
            IEnumerable<int> evens = numbers.Where(isEven);
            System.Console.WriteLine("EnumerableFromLinq: evens = " + string.Join(", ", evens));
        }

        private static void ListAndPredicates()
        {
            List<int> numbers = new List<int>(new int[] { 1, 2, 5, 4, 1, 7, 8, 9, 1, 11, -1, -2, -1, 0 });

            Predicate<int> oddFinder = (n) => (n % 2 != 0);
            Predicate<int> evenFinder = (n) => (n % 2 == 0);

            List<int> odds = numbers.FindAll(oddFinder);
            System.Console.WriteLine("ListAndPredicates: odds = " + string.Join(", ", odds));

            List<int> evens = numbers.FindAll(evenFinder);
            System.Console.WriteLine("ListAndPredicates: evens = " + string.Join(", ", evens));
        }
    }
}
