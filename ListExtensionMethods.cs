using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class ListExtensionMethods
    {
        public static void Shuffle<T>(this List<T> numbers)
        {
            Random random = new Random();
            int count = numbers.Count;

            while (count > 1)
            {
                count--;
                int next = random.Next(count + 1);
                T value = numbers[next];
                numbers[next] = numbers[count];
                numbers[count] = value;

            }

        }
    }
}
