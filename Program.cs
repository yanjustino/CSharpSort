using System;
using System.Diagnostics;
using CSharpSort.Data;
using CSharpSort.Algorithms;
using System.Collections.Generic;

namespace CSharpSort
{
    public class Program
    {
        private static Stopwatch stopWatch = new Stopwatch();
        private static DataRepository repository = new DataRepository();

        public static void Main(string[] args)
        {
            var data = IndexKeys();

            if (args[0] == "bubble")
                Execute(() => BubbleSort.Sort(data));

            else if (args[0] == "insertion")
                Execute(() => InsertionSort.Sort(data));

            Console.Read();
        }

        private static void Execute(Func<string[]> d)
        {
            stopWatch.Start();

            Console.WriteLine("Ordernando...");
            var ordered = d.Invoke();

            stopWatch.Stop();

            Console.WriteLine("registros: " + ordered.Length);
            PrintRunTime();
        }

        private static Dictionary<string, int> IndexKeys()
        {
            stopWatch.Start();
            Console.WriteLine("Indexando chaves de acesso...");
            var data = repository.IndexByMonthAndYear();
            stopWatch.Stop();
            PrintRunTime();

            return data;
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
