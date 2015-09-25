using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class NullConditionalExperiment
    {
        public void Main()
        {
            Test(null);
            Test("cat"); // True.
            Test("x");
            Test("parrot"); // True.
        }


        static void Test(string name)
        {
            if (name?.Length >= 3)
            {
                name.Dump();
            }
        }
    }
}
