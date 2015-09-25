using System.Linq;
using static System.Linq.Enumerable;


namespace new_csharp_6_features
{
    public class UsingStaticWithExtensionMethods
    {
        
        public void Main()
        {
            var data = Range(0, 10);

            Enumerable.Where(data, x => x % 2 == 0).Dump("Old way");

            //Does not compile.
            //Where(data, x => x%2 == 0).Dump("New way");  

            data.Where(x => x % 2 == 0).Dump("Works both ways");
        }
    }
}
