using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Algorithms
{
    internal class InsertionSort
    {
        private static int[] values;
        private static string[] keys;

        public static string[] Sort(Dictionary<string, int> data)
        {
            keys = data.Keys.ToArray();
            values = data.Values.ToArray();

            for (int i = 0; i < values.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (values[j - 1] > values[j])
                        Swap(j);
                    j--;
                }
            }
            return keys;
        }

        private static void Swap(int index)
        {
            int temp = values[index - 1];
            values[index - 1] = values[index];
            values[index] = temp;

            string tempK = keys[index - 1];
            keys[index - 1] = keys[index];
            keys[index] = tempK;
        }
    }
}
