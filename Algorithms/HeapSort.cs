using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Algorithms
{
    public static class HeapSort
    {
        private static int heapSize;
        private static string[] keys;

        public static string[] Sort(Dictionary<string, int> data)
        {
            int[] values = data.Values.ToArray();
            keys = data.Keys.ToArray();

            BuildHeap(values);
            for (int i = values.Length - 1; i >= 0; i--)
            {
                Swap(values, 0, i);
                heapSize--;
                Heapify(values, 0);
            }

            return keys;
        }

        private static void BuildHeap(int[] arr)
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
                Heapify(arr, i);
        }

        private static void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;

            string tempK = keys[x];
            keys[x] = keys[y];
            keys[y] = tempK;
        }

        private static void Heapify(int[] arr, int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;
            
            if (left <= heapSize && arr[left] > arr[index])
                largest = left;

            if (right <= heapSize && arr[right] > arr[largest])
                largest = right;

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
    }
}

