using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_csharp_6_features
{
    class Program
    {
        static void Main(string[] args)
        {
            new PropertyInitialization().Main();
            new GetterOnlyProperties().Main();
            new ExpressionBodyOnMethods().Main();
            new ExpressionBodyOnGetterProperties().Main();
            new ExpressionBodyOnIndexers().Main();
            new UsingStatic().Main();
            new UsingStaticWithExtensionMethods().Main();
            new NullConditional().Main();
            new NullConditionalExperiment().Main();
            new NullConditionalOnMethods().Main();
            new NullConditionalOnEvents().Main();
            new StringInterpolation().Main();
            new Nameof().Main();
            new IndexInitializersOnDictionary().Main();
            new IndexInitializersOnObjectIndexers().Main();
            new ExceptionFilters().Main();
            new ExceptionFiltersAbuse().Main();
            new AwaitInCatchAndFinally().Main();
            new ExtensionAddInCollectionInitializers().Main();

            Console.ReadLine();
        }
    }
}
