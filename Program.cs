using System;
using System.Diagnostics;
using CSharpSort.Data;
using CSharpSort.Algorithms;
using System.Collections.Generic;

namespace CSharpSort
{
    public class Program
    {
        private static int size;
        private static Stopwatch stopWatch = new Stopwatch();
        private static DataRepository repository;

        public static async void Main(string[] args)
        {
            if (ArgumentPolicies.IsValid(args))
            {
                size = Convert.ToInt32(args[1]);
                repository = new DataRepository(size);

                var data = IndexKeys();

                switch (args[0])
                {
                    case "bubble": Execute(() => BubbleSort.Sort(data)); break;
                    case "insertion": Execute(() => InsertionSort.Sort(data)); break;
                    case "heap": Execute(() => HeapSort.Sort(data)); break;
                    default: Console.WriteLine("método não reconhecido"); break;
                }
            }

            Console.Read();
        }

        private static Dictionary<string, int> IndexKeys()
        {
            Console.WriteLine("Indexando chaves de acesso...");

            stopWatch.Start();
            var data = repository.IndexByMonthAndYear();
            stopWatch.Stop();

            PrintRunTime();

            return data;
        }

        private static void Execute(Func<string[]> d)
        {
            Console.WriteLine("Ordernando...");

            stopWatch.Start();
            var ordered = d.Invoke();
            stopWatch.Stop();

            Console.WriteLine("registros: " + ordered.Length);
            repository.Save(ordered);
            PrintRunTime();
            Console.WriteLine("ordenação concluída");
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
            Console.WriteLine();
        }

    }
}
