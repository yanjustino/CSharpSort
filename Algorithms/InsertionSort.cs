using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Algorithms
{
    internal class InsertionSort
    {
        public static string[] performInsertionSort(Dictionary<string, int> data)
        {
            int[] values = data.Values.ToArray();
            string[] keys = data.Keys.ToArray();

            for (int i = 0; i < values.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (values[j - 1] > values[j])
                    {
                        int temp = values[j - 1];
                        values[j - 1] = values[j];
                        values[j] = temp;

                        string tempK = keys[j - 1];
                        keys[j - 1] = keys[j];
                        keys[j] = tempK;
                    }
                    j--;
                }
            }
            return keys;
        }
    }
}
