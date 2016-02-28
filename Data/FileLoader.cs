using System.IO;
using System.Linq;

namespace CSharpSort.Data
{
    internal static class FileLoader
    {
        public static string[] Load(int size)
        {
            return File.ReadAllLines("data/chaves-nfe.txt")
                       .Take(size)
                       .ToArray();
        }

        public static void Save(string[] lines)
        {
            File.WriteAllLines("data/out.txt", lines);
        }
    }
}
