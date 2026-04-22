using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.BasisExtensionMethods.Cons.Extensions
{
    public static class GenericExtensions
    {
        public static T GetRandom<T>(this IEnumerable<T> input)
        {
            var random = new Random();
            var randomIndex = random.Next(0, input.Count() - 1);
            return input.ToArray()[randomIndex];
        }
    }
}
