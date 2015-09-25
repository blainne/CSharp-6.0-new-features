using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class ExpressionBodyOnGetterProperties
    {
        public void Main()
        {
            OldWayNiceDate.Dump("Old way");
            NewWayNiceDate.Dump("New way");
        }


        string OldWayNiceDate
        {
            get { return GetDate(); }
        }

        string NewWayNiceDate =>
            GetDate();



        private string GetDate()
        {
            return String.Format("{0} {1}",
                                 DateTime.Now.ToShortDateString(),
                                 DateTime.Now.ToShortTimeString());
        }
    }
}
