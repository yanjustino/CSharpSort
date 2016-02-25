using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Algorithms
{
    public static class BubbleSort
    {
        public static string[] bubblesort(Dictionary<string, int> data)
        {
            int[] values = data.Values.ToArray();
            string[] keys = data.Keys.ToArray();

            int temp;
            string tempkey;

            for (int i = 1; i <= values.Length; i++)
            {
                for (int j = 0; j < values.Length - i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;

                        tempkey = keys[j];
                        keys[j] = keys[j + 1];
                        keys[j + 1] = tempkey;
                    }
                }
            }
            return keys;
        }
    }
}

