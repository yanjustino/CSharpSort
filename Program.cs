using System;
using System.Diagnostics;
using CSharpSort.Data;
using CSharpSort.Algorithms;

namespace CSharpSort
{
    public class Program
    {
        private static Stopwatch stopWatch = new Stopwatch();
        private static DataRepository repository = new DataRepository();

        public static void Main(string[] args)
        {
            stopWatch.Start();
            Console.WriteLine("Indexando chaves de acesso...");
            var data = repository.IndexByMonthAndYear();
            stopWatch.Stop();

            PrintRunTime();

            stopWatch.Start();
            Console.WriteLine("Ordernando...");
            var ordered = BubbleSort.bubblesort(data);
            //var ordered = InsertionSort.performInsertionSort(data);

            stopWatch.Stop();

            Console.WriteLine("registros: " + ordered.Length);
            PrintRunTime();

            Console.Read();
        }

        private static void PrintRunTime()
        {

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime =
                String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours,
                        ts.Minutes,
                        ts.Seconds,
                        ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
        }

    }
}
