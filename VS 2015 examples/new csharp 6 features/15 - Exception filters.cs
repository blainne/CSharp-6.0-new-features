using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class ExceptionFilters
    {
        public void Main()
        {
            "".Dump("Old Way");
            try
            {
                OldWay(handleInvalid: true, catchAll: false);
                OldWay(handleInvalid: false, catchAll: true);
                OldWay(handleInvalid: false, catchAll: false);
            }
            catch (Exception e)
            {
                "Caught in main".Dump();
            }


            "".Dump("New Way");
            try
            {
                NewWay(handleInvalid: true, catchAll: false);
                NewWay(handleInvalid: false, catchAll: true);
                NewWay(handleInvalid: false, catchAll: false);
            }
            catch (Exception e)
            {
                "Caught in main".Dump();
            }
        }

        public static void OldWay(bool handleInvalid, bool catchAll)
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException e)
            {
                if (handleInvalid)
                {
                    "Handled invalid.".Dump();
                }

                else if (catchAll)
                {
                    "Handled invalid (catch all flag).".Dump();
                }

                else throw;
            }
        }

        public static void NewWay(bool handleInvalid, bool catchAll)
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException) when (handleInvalid)
            {
                "Handled invalid.".Dump();
            }
            catch (InvalidOperationException) when (catchAll)
            {
                "Handled invalid (catch all flag).".Dump();
            }
        }
    }
}
