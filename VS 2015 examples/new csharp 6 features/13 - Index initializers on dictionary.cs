using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class IndexInitializersOnDictionary
    {
        public void Main()
        {
            DictionaryOldWay();
            DictionaryNewWay();
        }


        public static void DictionaryOldWay()
        {
            var dict = new Dictionary<string, int>()
            {
                {"answer", 42},
                {"year", 1984},
                {"bicycles", 9000000}
            };
            dict.Dump("Old way");
        }

        public static void DictionaryNewWay()
        {
            var dict = new Dictionary<string, int>
            {
                ["answer"] = 42,
                ["year"] = 1984,
                ["bicycles"] = 9000000
            };

            dict.Dump("New way");
        }
    }
}
