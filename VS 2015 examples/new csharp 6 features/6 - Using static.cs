using System;

using static System.DayOfWeek;
using static System.Math;
using static System.Console;

namespace new_csharp_6_features
{
    public class UsingStatic
    {
        public void Main()
        {
            (DayOfWeek.Friday - DayOfWeek.Monday).Dump("Old way");
            (Friday - Monday).Dump("New way");


            Math.Round(Math.PI, 5).Dump("Old way");
            Round(PI, 5).Dump("New way");


            Console.WriteLine("Old way");
            WriteLine("New way");
        }
    }
}
