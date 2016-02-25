using System.IO;

namespace CSharpSort.Data
{
    internal static class FileLoader
    {
        public static string[] Load()
        {
            return File.ReadAllLines("data/chaves-nfe.txt");
        }
    }
}
