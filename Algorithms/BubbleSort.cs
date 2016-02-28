using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Algorithms
{
    public static class BubbleSort
    {
        private static int[] values;
        private static string[] keys;

        public static string[] Sort(Dictionary<string, int> data)
        {
            values = data.Values.ToArray();
            keys = data.Keys.ToArray();

            for (int i = 1; i <= values.Length; i++)
            {
                for (int j = 0; j < values.Length - i; j++)
                {
                    if (values[j] > values[j + 1])
                        Swap(j);
                }
            }
            return keys;
        }

        private static void Swap(int index)
        {
            var temp = values[index];
            values[index] = values[index + 1];
            values[index + 1] = temp;

            var tempkey = keys[index];
            keys[index] = keys[index + 1];
            keys[index + 1] = tempkey;
        }
    }
}

