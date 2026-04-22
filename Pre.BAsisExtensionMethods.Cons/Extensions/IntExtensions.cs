using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.BasisExtensionMethods.Cons.Extensions
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }
        public static int Minimum(this IEnumerable<int> numbers)
        {
            var minimum = numbers.ToArray()[0];
            foreach (var number in numbers)
            {
                if (minimum > number)
                    minimum = number;
            }
            return minimum;
        }
        public static IEnumerable<int> GetEvenNumbers(this IEnumerable<int> numbers)
        {
            //classic
            //List<int> evenNumbers = new();
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //        evenNumbers.Add(number);
            //}
            //return evenNumbers;
            //yield keyword
            //List<int> evenNumbers = new();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    yield return number;
            }
        }
    }
}
