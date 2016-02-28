using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Data
{

    public class DataRepository
    {
        private string[] _file;

        public DataRepository(int size)
        {
            _file = FileLoader.Load(size);
        }

        public Dictionary<string, int> IndexByMonthAndYear()
        {
            return _file.ToDictionary
                (
                   key => key, 
                   key => key.GetMonthAndYear()
                );
        } 
        
        public void Save(string[] lines)
        {
            FileLoader.Save(lines);
        }
    }
}
