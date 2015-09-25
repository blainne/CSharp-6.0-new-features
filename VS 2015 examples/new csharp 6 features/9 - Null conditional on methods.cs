using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    public class NullConditionalOnMethods
    {
        public void Main()
        {
            "".Dump("Old way with good printer");
            OldWayPrinter(new Printer());

            "".Dump("Old way with null printer");
            OldWayPrinter(null);

            "".Dump("New way with good printer");
            NewWayPrinter(new Printer());

            "".Dump("New way with null printer");
            NewWayPrinter(null);
        }


        public void OldWayPrinter(Printer printer)
        {
            if (printer != null)
                printer.Print();

            var text = (printer != null)
                       ? printer.GetPreview()
                       : "NullPrinterException :-)";

            text.Dump();
        }

        public void NewWayPrinter(Printer printer)
        {
            printer?.Print();

            var text = printer?.GetPreview() ?? "NullPrinterException :-)";
            text.Dump();
        }

        public class Printer
        {
            public void Print()
            {
                "Okay, I'm printing.".Dump();
            }

            public string GetPreview()
            {
                return "Print preview";
            }
        }
    }
}
