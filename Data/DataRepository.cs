using System.Collections.Generic;
using System.Linq;

namespace CSharpSort.Data
{

    public class DataRepository
    {
        private string[] _file;

        public DataRepository()
        {
            _file = FileLoader.Load();
        }

        public Dictionary<string, int> IndexByMonthAndYear()
        {
            return _file.ToDictionary
                (
                   key => key, 
                   key => key.GetMonthAndYear()
                );
        } 
    }
}
